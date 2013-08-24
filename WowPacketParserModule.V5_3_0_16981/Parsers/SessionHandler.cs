﻿using System;
using System.Text;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V5_3_0_16981.Parsers
{
    public static class SessionHandler
    {
        [Parser(Opcode.SMSG_AUTH_CHALLENGE)]
        public static void HandleServerAuthChallenge(Packet packet)
        {
            packet.ReadUInt32("Key pt1");
            packet.ReadUInt32("Key pt2");
            packet.ReadUInt32("Key pt3");
            packet.ReadUInt32("Key pt4");
            packet.ReadUInt32("Key pt5");
            packet.ReadUInt32("Key pt6");
            packet.ReadUInt32("Key pt7");
            packet.ReadUInt32("Key pt8");
            packet.ReadUInt32("Server Seed");
            packet.ReadByte("Unk Byte");
        }

        [Parser(Opcode.CMSG_AUTH_SESSION)]
        public static void HandleAuthSession(Packet packet)
        {
            var sha = new byte[20];
            packet.ReadUInt32("UInt32 2");//16
            sha[8] = packet.ReadByte();//40
            sha[13] = packet.ReadByte();//45
            sha[3] = packet.ReadByte();//35
            packet.ReadUInt32("UInt32 3");//28
            sha[6] = packet.ReadByte();//38
            packet.ReadEnum<ClientVersionBuild>("Client Build", TypeCode.Int16);//20
            sha[2] = packet.ReadByte();//34
            sha[0] = packet.ReadByte();//32
            sha[7] = packet.ReadByte();//39
            sha[11] = packet.ReadByte();//43
            packet.ReadUInt32("UInt32 4");//56
            sha[5] = packet.ReadByte();//37
            sha[15] = packet.ReadByte();//47
            sha[14] = packet.ReadByte();//46
            sha[12] = packet.ReadByte();//44
            packet.ReadInt64("Int64");//64,68
            packet.ReadByte("Unk Byte");//61
            packet.ReadUInt32("Client seed");//52
            packet.ReadUInt32("UInt32 1");//24
            sha[1] = packet.ReadByte();//33
            sha[9] = packet.ReadByte();//41
            sha[4] = packet.ReadByte();//36
            sha[17] = packet.ReadByte();//49
            sha[16] = packet.ReadByte();//48
            sha[19] = packet.ReadByte();//51
            sha[18] = packet.ReadByte();//50
            sha[10] = packet.ReadByte();//42
            packet.ReadByte("Unk Byte");//60

            using (var addons = new Packet(packet.ReadBytes(packet.ReadInt32()), packet.Opcode, packet.Time, packet.Direction, packet.Number, packet.Writer, packet.FileName))
            {
                var pkt2 = addons;
                CoreParsers.AddonHandler.ReadClientAddonsList(ref pkt2);
            }

            packet.ReadBit("Unk bit");
            var size = (int)packet.ReadBits(11);
            packet.ResetBitReader();
            packet.WriteLine("Account name: {0}", Encoding.UTF8.GetString(packet.ReadBytes(size)));
            packet.WriteLine("Proof SHA-1 Hash: " + Utilities.ByteArrayToHexString(sha));
        }

        [Parser(Opcode.SMSG_AUTH_RESPONSE)]
        public static void HandleAuthResponse(Packet packet)
        {
            var count = 0u;
            var count1 = 0u;
            var isQueued = packet.ReadBit("Is In Queue");

            if (isQueued)
                packet.ReadBit("unk0");

            var hasAccountData = packet.ReadBit("Has Account Data");

            if (hasAccountData)
            {
                packet.ReadBit("Unk 1");
                packet.ReadBit("Unk 2");
                count1 = packet.ReadBits("Race Activation Count", 23);
                packet.ReadBit("Unk 3");
                packet.ReadBits("Unkbits", 21);
                count = packet.ReadBits("Class Activation Count", 23);
                packet.ReadBits("Unkbits", 22);
                packet.ReadBit("Unk 4");

            }
            packet.ResetBitReader();

            if (hasAccountData)
            {
                packet.ReadByte("unk");
                for (var i = 0; i < count; ++i)
                {
                    packet.ReadEnum<ClientType>("Class Expansion", TypeCode.Byte, i);
                    packet.ReadEnum<Class>("Class", TypeCode.Byte, i);
                }

                packet.ReadInt16("UnkInt16 1");
                packet.ReadInt16("UnkInt16 2");

                for (var i = 0; i < count1; ++i)
                {
                    packet.ReadEnum<ClientType>("Race Expansion", TypeCode.Byte, i);
                    packet.ReadEnum<Race>("Race", TypeCode.Byte, i);
                }

                packet.ReadUInt32("Unk 8");
                packet.ReadUInt32("Unk 9");
                packet.ReadUInt32("Unk 10");


                packet.ReadEnum<ClientType>("Account Expansion", TypeCode.Byte);
                packet.ReadEnum<ClientType>("Player Expansion", TypeCode.Byte);

            }

            packet.ReadEnum<ResponseCode>("Auth Code", TypeCode.Byte);

            if (isQueued)
                packet.ReadUInt32("Unk 11");
        }

        [Parser(Opcode.SMSG_MOTD)]
        public static void HandleMessageOfTheDay(Packet packet)
        {
            var lineCount = packet.ReadBits("Line Count", 4);
            var lineLength = new int[lineCount];
            for (var i = 0; i < lineCount; i++)
                lineLength[i] = (int)packet.ReadBits(7);

            for (var i = 0; i < lineCount; i++)
                packet.ReadWoWString("Line", lineLength[i], i);
        }
    }
}