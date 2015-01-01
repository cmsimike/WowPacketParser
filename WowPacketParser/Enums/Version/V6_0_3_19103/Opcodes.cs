using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V6_0_3_19103
{
    public static class Opcodes_6_0_3
    {
        public static BiDictionary<Opcode, int> Opcodes(Direction direction)
        {
            if (direction == Direction.ClientToServer || direction == Direction.BNClientToServer)
                return ClientOpcodes;
            if (direction == Direction.ServerToClient || direction == Direction.BNServerToClient)
                return ServerOpcodes;
            return MiscOpcodes;
        }

        private static readonly BiDictionary<Opcode, int> ClientOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ACTIVATETAXI, 0x0311},
            {Opcode.CMSG_ACTIVATETAXIEXPRESS, 0x1B52},
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x03F4},
            {Opcode.CMSG_ADD_FRIEND, 0x0DB9},
            {Opcode.CMSG_ADD_IGNORE, 0x1321},
            {Opcode.CMSG_ADD_MUTE, 0x098A},
            {Opcode.CMSG_AREATRIGGER, 0x01B4},
            {Opcode.CMSG_ATTACKSTOP, 0x065B},
            {Opcode.CMSG_ATTACKSWING, 0x1E9B},
            {Opcode.CMSG_AUCTION_HELLO, 0x13EA},
            {Opcode.CMSG_AUTH_CONTINUED_SESSION, 0x0485},
            {Opcode.CMSG_AUTH_SESSION, 0x0487},
            {Opcode.CMSG_AUTOBANK_ITEM, 0x0751},
            {Opcode.CMSG_AUTOEQUIP_ITEM, 0x0F35},
            {Opcode.CMSG_AUTOSTORE_BAG_ITEM, 0x0F18},
            {Opcode.CMSG_AUTOSTORE_BANK_ITEM, 0x0732},
            {Opcode.CMSG_AUTOSTORE_LOOT_ITEM, 0x0609},
            {Opcode.CMSG_BANKER_ACTIVATE, 0x1B24},
            {Opcode.CMSG_BATTLE_PET_DELETE_PET, 0x07B9},
            {Opcode.CMSG_BATTLE_PET_MODIFY_NAME, 0x03A9},
            {Opcode.CMSG_BATTLE_PET_NAME_QUERY, 0x041C},
            {Opcode.CMSG_BATTLE_PET_SET_BATTLE_SLOT, 0x120B},
            {Opcode.CMSG_BATTLE_PAY_GET_PRODUCT_LIST_QUERY, 0x1389},
            {Opcode.CMSG_BATTLE_PAY_GET_PURCHASE_LIST_QUERY, 0x120C},
            {Opcode.CMSG_BATTLEFIELD_LIST, 0x03B1},
            {Opcode.CMSG_BATTLEFIELD_MGR_ENTRY_INVITE_RESPONSE, 0x059A},
            {Opcode.CMSG_BATTLEFIELD_MGR_EXIT_REQUEST, 0x1381},
            {Opcode.CMSG_BATTLEFIELD_MGR_QUEUE_INVITE_RESPONSE, 0x122A},
            {Opcode.CMSG_BATTLEFIELD_PORT, 0x11EB},
            {Opcode.CMSG_BATTLEFIELD_STATUS, 0x0320},
            {Opcode.CMSG_BATTLEMASTER_JOIN, 0x0D2E},
            {Opcode.CMSG_BATTLEMASTER_JOIN_ARENA, 0x0DAE},
            {Opcode.CMSG_BINDER_ACTIVATE, 0x02F3},
            {Opcode.CMSG_BUYBACK_ITEM, 0x02D3},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x0A25},
            {Opcode.CMSG_BUY_ITEM, 0x0352},
            {Opcode.CMSG_CANCEL_AURA, 0x08AE},
            {Opcode.CMSG_CANCEL_TRADE, 0x1159},
            {Opcode.CMSG_CAST_SPELL, 0x08FE},
            {Opcode.CMSG_CHANNEL_ANNOUNCEMENTS, 0x1313},
            {Opcode.CMSG_CHANNEL_BAN, 0x1A82},
            {Opcode.CMSG_CHANNEL_DECLINE_INVITE, 0x19DB},
            {Opcode.CMSG_CHANNEL_DISPLAY_LIST, 0x093B},
            {Opcode.CMSG_CHANNEL_KICK, 0x0A2A},
            {Opcode.CMSG_CHANNEL_LIST, 0x091C},
            {Opcode.CMSG_CHANNEL_MODERATOR, 0x088B},
            {Opcode.CMSG_CHANNEL_MUTE, 0x18AB},
            {Opcode.CMSG_CHANNEL_OWNER, 0x0BFA},
            {Opcode.CMSG_CHANNEL_PASSWORD, 0x1113},
            {Opcode.CMSG_CHANNEL_INVITE, 0x1933},
            {Opcode.CMSG_CHANNEL_SET_OWNER, 0x0174},
            {Opcode.CMSG_CHANNEL_SILENCE_VOICE, 0x0AA3},
            {Opcode.CMSG_CHANNEL_SILENCE_ALL, 0x11FB},
            {Opcode.CMSG_CHANNEL_UNBAN, 0x0BCB},
            {Opcode.CMSG_CHANNEL_UNMODERATOR, 0x1AA1},
            {Opcode.CMSG_CHANNEL_UNMUTE, 0x0A81},
            {Opcode.CMSG_CHANNEL_UNSILENCE_ALL, 0x1164},
            {Opcode.CMSG_CHANNEL_UNSILENCE_VOICE, 0x0B4C},
            {Opcode.CMSG_CHANNEL_VOICE_OFF, 0x016C},
            {Opcode.CMSG_CHANNEL_VOICE_ON, 0x0374},
            {Opcode.CMSG_CHAR_CREATE, 0x070D},
            {Opcode.CMSG_CHAR_CUSTOMIZE, 0x072A},
            {Opcode.CMSG_CHAR_DELETE, 0x030E},
            {Opcode.CMSG_CHAR_ENUM, 0x0918},
            {Opcode.CMSG_CHAR_RACE_OR_FACTION_CHANGE, 0x1209},
            {Opcode.CMSG_CHAR_RENAME, 0x038B},
            {Opcode.CMSG_CHAR_UNDELETE_ENUM, 0x0F2D},
            {Opcode.CMSG_CREATURE_QUERY, 0x0505},
            {Opcode.CMSG_COMPLAIN, 0x0917},
            {Opcode.CMSG_CONNECT_TO_FAILED, 0x0135},
            {Opcode.CMSG_DB_QUERY_BULK, 0x138B},
            {Opcode.CMSG_DEL_FRIEND, 0x0F2A},
            {Opcode.CMSG_DEL_IGNORE, 0x033D},
            {Opcode.CMSG_DEL_MUTE, 0x0128},
            {Opcode.CMSG_DESTROY_ITEM, 0x01EE},
            {Opcode.CMSG_ENABLETAXI, 0x00D2},
            {Opcode.CMSG_EQUIPMENT_SET_SAVE, 0x1B54},
            {Opcode.CMSG_FORCE_MOVE_ROOT_ACK, 0x0B73},
            {Opcode.CMSG_GARRISON_COMPLETE_MISSION, 0x102C},
            {Opcode.CMSG_GARRISON_MISSION_BONUS_ROLL, 0x02C2},
            {Opcode.CMSG_GARRISON_START_MISSION, 0x1624},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x03AE},
            {Opcode.CMSG_GAMEOBJ_REPORT_USE, 0x0B19},
            {Opcode.CMSG_GAMEOBJ_USE, 0x082E},
            {Opcode.CMSG_GET_MAIL_LIST, 0x0BD3},
            {Opcode.CMSG_GOSSIP_HELLO, 0x00F3},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x0332},
            {Opcode.CMSG_GUILD_BANK_MONEY_WITHDRAWN_QUERY, 0x063D},
            {Opcode.CMSG_GUILD_INVITE, 0x19A4},
            {Opcode.CMSG_GUILD_PERMISSIONS, 0x1436},
            {Opcode.CMSG_GUILD_QUERY, 0x0930},
            {Opcode.CMSG_GUILD_QUERY_RANKS, 0x0C37},
            {Opcode.CMSG_GUILD_REQUEST_PARTY_STATE, 0x0A8E},
            {Opcode.CMSG_GUILD_ROSTER, 0x0638},
            {Opcode.CMSG_ITEM_REFUND_INFO, 0x0924},
            {Opcode.CMSG_JOIN_CHANNEL, 0x0B4B},
            {Opcode.CMSG_LEAVE_CHANNEL, 0x19F2},
            {Opcode.CMSG_LFG_GET_STATUS, 0x1BA4},
            {Opcode.CMSG_LFG_LOCK_INFO_REQUEST, 0x030F},
            {Opcode.CMSG_LOAD_SCREEN, 0x0B08},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x03C2},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x1911},
            {Opcode.CMSG_LOOT, 0x01B1},
            {Opcode.CMSG_LOOT_METHOD, 0x0729},
            {Opcode.CMSG_LOOT_RELEASE, 0x1199},
            {Opcode.CMSG_LOG_DISCONNECT, 0x04D5},
            {Opcode.CMSG_MAIL_CREATE_TEXT_ITEM, 0x13D1},
            {Opcode.CMSG_MAIL_DELETE, 0x068C},
            {Opcode.CMSG_MAIL_MARK_AS_READ, 0x02D1},
            {Opcode.CMSG_MAIL_RETURN_TO_SENDER, 0x1B84},
            {Opcode.CMSG_MAIL_TAKE_ITEM, 0x0030},
            {Opcode.CMSG_MAIL_TAKE_MONEY, 0x0806},
            {Opcode.CMSG_MESSAGECHAT_ADDON_GUILD, 0x137C},
            {Opcode.CMSG_MESSAGECHAT_ADDON_OFFICER, 0x188A},
            {Opcode.CMSG_MESSAGECHAT_ADDON_PARTY, 0x015C},
            {Opcode.CMSG_MESSAGECHAT_ADDON_RAID, 0x082C},
            {Opcode.CMSG_MESSAGECHAT_ADDON_WHISPER, 0x18A2},
            {Opcode.CMSG_MESSAGECHAT_AFK, 0x1BDC},
            {Opcode.CMSG_MESSAGECHAT_CHANNEL, 0x0913},
            {Opcode.CMSG_MESSAGECHAT_DND, 0x0AAB},
            {Opcode.CMSG_MESSAGECHAT_EMOTE, 0x113C},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x0B1B},
            {Opcode.CMSG_MESSAGECHAT_INSTANCE, 0x0134},
            {Opcode.CMSG_MESSAGECHAT_PARTY, 0x0803},
            {Opcode.CMSG_MESSAGECHAT_OFFICER, 0x0114},
            {Opcode.CMSG_MESSAGECHAT_RAID, 0x0B33},
            {Opcode.CMSG_MESSAGECHAT_RAID_WARNING, 0x0313},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x1884},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x1829},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x1161},
            {Opcode.CMSG_MINIMAP_PING, 0x0837},
            {Opcode.CMSG_MOVE_GRAVITY_DISABLE_ACK, 0x0553},
            {Opcode.CMSG_MOVE_FALL_LAND, 0x0D54},
            {Opcode.CMSG_MOVE_FALL_RESET, 0x0522},
            {Opcode.CMSG_MOVE_FORCE_RUN_SPEED_CHANGE_ACK, 0x0B7C},
            {Opcode.CMSG_MOVE_FORCE_SWIM_SPEED_CHANGE_ACK, 0x008A},
            {Opcode.CMSG_MOVE_HEARTBEAT, 0x19C1},
            {Opcode.CMSG_MOVE_HOVER_ACK, 0x0543},
            {Opcode.CMSG_MOVE_JUMP, 0x0282},
            {Opcode.CMSG_MOVE_SET_COLLISION_HEIGHT_ACK, 0x0141},
            {Opcode.CMSG_MOVE_SET_FACING, 0x19D2},
            {Opcode.CMSG_MOVE_SET_PITCH, 0x0D92},
            {Opcode.CMSG_MOVE_SET_RUN_MODE, 0x0D51},
            {Opcode.CMSG_MOVE_SET_WALK_MODE, 0x0544},
            {Opcode.CMSG_MOVE_SPLINE_DONE, 0x0B63},
            {Opcode.CMSG_MOVE_START_ASCEND, 0x0D41},
            {Opcode.CMSG_MOVE_START_BACKWARD, 0x0583},
            {Opcode.CMSG_MOVE_START_DESCEND, 0x0B79},
            {Opcode.CMSG_MOVE_START_FORWARD, 0x0521},
            {Opcode.CMSG_MOVE_START_PITCH_DOWN, 0x1974},
            {Opcode.CMSG_MOVE_START_PITCH_UP, 0x0151},
            {Opcode.CMSG_MOVE_START_SWIM, 0x0B7A},
            {Opcode.CMSG_MOVE_START_TURN_LEFT, 0x000B},
            {Opcode.CMSG_MOVE_START_TURN_RIGHT, 0x0D14},
            {Opcode.CMSG_MOVE_START_STRAFE_LEFT, 0x0082},
            {Opcode.CMSG_MOVE_START_STRAFE_RIGHT, 0x1151},
            {Opcode.CMSG_MOVE_STOP, 0x0513},
            {Opcode.CMSG_MOVE_STOP_ASCEND, 0x197C},
            {Opcode.CMSG_MOVE_STOP_PITCH, 0x0503},
            {Opcode.CMSG_MOVE_STOP_STRAFE, 0x01D1},
            {Opcode.CMSG_MOVE_STOP_SWIM, 0x097C},
            {Opcode.CMSG_MOVE_STOP_TURN, 0x0964},
            {Opcode.CMSG_MOVE_TELEPORT_ACK, 0x0D01},
            {Opcode.CMSG_MOVE_TIME_SKIPPED, 0x19C2},
            {Opcode.CMSG_MOVE_WATER_WALK_ACK, 0x0B6C},
            {Opcode.CMSG_MOVE_WORLDPORT_ACK, 0x0938},
            {Opcode.CMSG_NAME_QUERY, 0x0B15},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x0ECB},
            {Opcode.CMSG_PAGE_TEXT_QUERY, 0x0BBB},
            {Opcode.CMSG_PET_ACTION, 0x133A},
            {Opcode.CMSG_PET_CAST_SPELL, 0x0286},
            {Opcode.CMSG_PET_NAME_QUERY, 0x1433},
            {Opcode.CMSG_PING, 0x0416},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0B1D},
            {Opcode.CMSG_PLAYED_TIME, 0x1BB2},
            {Opcode.CMSG_PVP_LOG_DATA, 0x08B5},
            {Opcode.CMSG_QUERY_BATTLEFIELD_STATE, 0x0359},
            {Opcode.CMSG_QUERY_NEXT_MAIL_TIME, 0x0B31},
            {Opcode.CMSG_QUESTGIVER_ACCEPT_QUEST, 0x13D3},
            {Opcode.CMSG_QUESTGIVER_CHOOSE_REWARD, 0x0DAD},
            {Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST, 0x1E8A},
            {Opcode.CMSG_QUESTGIVER_HELLO, 0x058E}, 
            {Opcode.CMSG_QUESTGIVER_QUERY_QUEST, 0x1924},
            {Opcode.CMSG_QUESTGIVER_REQUEST_REWARD, 0x022E},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0x0131},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x01E2},
            {Opcode.CMSG_QUEST_NPC_QUERY, 0x0B81},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x0BD9},
            {Opcode.CMSG_QUEST_QUERY, 0x09A6},
            {Opcode.CMSG_QUEUED_MESSAGES_END, 0x04DF},
            {Opcode.CMSG_RANDOM_ROLL, 0x12AA},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x1981},
            {Opcode.CMSG_RECRUIT_A_FRIEND, 0x07BA},
            {Opcode.CMSG_REALM_NAME_QUERY, 0x1189},
            {Opcode.CMSG_REORDER_CHARACTERS, 0x0DAA},
            {Opcode.CMSG_REPAIR_ITEM, 0x0B54},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x0F3E},
            {Opcode.CMSG_REQUEST_CEMETERY_LIST, 0x10A2},
            {Opcode.CMSG_RETURN_TO_GRAVEYARD, 0x12EA},
            {Opcode.CMSG_ROUTER_CLIENT_LOG_STREAMING_ERROR, 0x0C10},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x0053},
            {Opcode.CMSG_SEND_MAIL, 0x0910},
            {Opcode.CMSG_SELL_ITEM, 0x0351},
            {Opcode.CMSG_SETSHEATHED, 0x1B43},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x0599},
            {Opcode.CMSG_SET_ACTIVE_MOVER, 0x0971},
            {Opcode.CMSG_SET_ACTIVE_VOICE_CHANNEL, 0x031E},
            {Opcode.CMSG_SET_LOOT_SPECIALIZATION, 0x0226},
            {Opcode.CMSG_SET_SELECTION, 0x05BD},
            {Opcode.CMSG_SET_SPECIALIZATION, 0x0AC5},
            {Opcode.CMSG_SPLIT_ITEM, 0x0795},
            {Opcode.CMSG_SHOWING_CLOAK, 0x0132},
            {Opcode.CMSG_SHOWING_HELM, 0x11E1},
            {Opcode.CMSG_SPELLCLICK, 0x0BC2},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_COMPLAINT, 0x0B37}, // need structure | 2871 (0x0B37) | 0x0098E908 | 0x005E41E4 |
            {Opcode.CMSG_SUSPEND_COMMS_ACK, 0x0C56},
            {Opcode.CMSG_SUSPEND_TOKEN_RESPONSE, 0x041E},
            {Opcode.CMSG_SWAP_INV_ITEM, 0x0F17},
            {Opcode.CMSG_SWAP_ITEM, 0x0736},
            {Opcode.CMSG_TAXINODE_STATUS_QUERY, 0x1BC1},
            {Opcode.CMSG_TRAINER_BUY_SPELL, 0x0A28},
            {Opcode.CMSG_TRAINER_LIST, 0x0A2E},
            {Opcode.CMSG_TRANSMOGRIFY_ITEMS, 0x0A85},
            {Opcode.CMSG_TEXT_EMOTE, 0x1901},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x0003},
            {Opcode.CMSG_TUTORIAL_FLAG, 0x0B16},
            {Opcode.CMSG_UNDELETE_CHARACTER, 0x0D99},
            {Opcode.CMSG_UNDELETE_COOLDOWN_STATUS_QUERY, 0x19A9},
            {Opcode.CMSG_UNLEARN_SKILL, 0x0A26},
            {Opcode.CMSG_USE_ITEM, 0x08B6},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x12A1},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x098D},
            {Opcode.CMSG_VOICE_SESSION_ENABLE, 0x1102},
            {Opcode.CMSG_VOID_STORAGE_QUERY, 0x019E},
            {Opcode.CMSG_VOID_STORAGE_TRANSFER, 0x0463},
            {Opcode.CMSG_VOID_STORAGE_UNLOCK, 0x13BB},
            {Opcode.CMSG_VOID_SWAP_ITEM, 0x0619},
            {Opcode.CMSG_WARDEN_DATA, 0x0BA1},
            {Opcode.CMSG_WHO, 0x1322},
            {Opcode.CMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x0302},
        };

        private static readonly BiDictionary<Opcode, int> ServerOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0120},
            {Opcode.SMSG_ACCOUNT_MOUNT_UPDATE, 0x0140},
            {Opcode.SMSG_ACCOUNT_TOYS_UPDATE, 0x0590},
            {Opcode.SMSG_ACHIEVEMENT_EARNED, 0x010E},
            {Opcode.SMSG_ACTION_BUTTONS, 0x1D1F},
            {Opcode.SMSG_ACTIVATE_TAXI_REPLY, 0x1321},
            {Opcode.SMSG_ADDON_INFO, 0x1D9F},
            {Opcode.SMSG_ADJUST_SPLINE_DURATION, 0x0104},
            {Opcode.SMSG_AE_LOOT_TARGETS, 0x15AF},
            {Opcode.SMSG_AI_REACTION, 0x0BA1},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_ACCOUNT, 0x0123},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_PLAYER, 0x0030},
            {Opcode.SMSG_ARENA_SEASON_WORLD_STATE, 0x09E3},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x1204},
            {Opcode.SMSG_ATTACKSTART, 0x1D3E},
            {Opcode.SMSG_ATTACKSTOP, 0x1382},
            {Opcode.SMSG_COMBAT_EVENT_FAILED, 0x1DAF},
            {Opcode.SMSG_ATTACKSWING_ERROR, 0x0509},
            {Opcode.SMSG_AUCTION_COMMAND_RESULT, 0x0B2D},
            {Opcode.SMSG_AUCTION_HELLO, 0x011F},
            {Opcode.SMSG_AUCTION_LIST_ITEMS_RESULT, 0x0BA4},
            {Opcode.SMSG_AURA_POINTS_DEPLETED, 0x093B},
            {Opcode.SMSG_AURA_UPDATE, 0x091C},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x1759},
            {Opcode.SMSG_AUTH_RESPONSE, 0x0DA9},
            {Opcode.SMSG_AVAILABLE_VOICE_CHANNEL, 0x04D4},
            {Opcode.SMSG_BARBER_SHOP_RESULT, 0x150D},
            {Opcode.SMSG_BATTLE_PAY_DISTRIBUTION_UPDATE, 0x0BE3},
            {Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE, 0x0F2A},
            {Opcode.SMSG_BATTLE_PAY_GET_PRODUCT_LIST_RESPONSE, 0x12A4},
            {Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE, 0x168A},
            {Opcode.SMSG_BATTLE_PET_NAME_QUERY_RESPONSE, 0x09EC},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x19A2},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x01A3},
            {Opcode.SMSG_BATTLEFIELD_LIST, 0x11A1},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECTED, 0x0DAF},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTERED, 0x11A3},
            {Opcode.SMSG_BATTLEFIELD_RATED_INFO, 0x1F0A},
            {Opcode.SMSG_BATTLEFIELD_STATUS_NONE, 0x1E89},
            {Opcode.SMSG_BATTLEFIELD_STATUS_QUEUED, 0x002D},
            {Opcode.SMSG_BATTLEFIELD_STATUS_ACTIVE, 0x1284},
            {Opcode.SMSG_BATTLEFIELD_STATUS_NEEDCONFIRMATION, 0x1719},
            {Opcode.SMSG_BATTLEFIELD_STATUS_FAILED, 0x0308},
            {Opcode.SMSG_BATTLEFIELD_STATUS_WAITFORGROUPS, 0x082D},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_JOINED, 0x13EA},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_LEFT, 0x1BD1},
            {Opcode.SMSG_BINDER_CONFIRM, 0x0B11},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x0A30},
            {Opcode.SMSG_BUY_FAILED, 0x013A},
            {Opcode.SMSG_BUY_ITEM, 0x0BD1},
            {Opcode.SMSG_CALENDAR_SEND_NUM_PENDING, 0x1B3A},
            {Opcode.SMSG_CANCEL_AUTO_REPEAT, 0x0B18},
            {Opcode.SMSG_CANCEL_COMBAT, 0x05AD},
            {Opcode.SMSG_CAST_FAILED, 0x1A89},
            {Opcode.SMSG_CHANNEL_LIST, 0x1411},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x0643},
            {Opcode.SMSG_CHANNEL_NOTIFY_JOINED, 0x1602},
            {Opcode.SMSG_CHANNEL_NOTIFY_LEFT, 0x1452},
            {Opcode.SMSG_CHANNEL_START, 0x016C},
            {Opcode.SMSG_CHANNEL_UPDATE, 0x19DB},
            {Opcode.SMSG_CHAT_PLAYER_NOT_FOUND, 0x0614},
            {Opcode.SMSG_CHAR_CREATE, 0x0107},
            {Opcode.SMSG_CHAR_CUSTOMIZE, 0x1932},
            {Opcode.SMSG_CHAR_CUSTOMIZE_RESULT, 0x0BAA},
            {Opcode.SMSG_CHAR_DELETE, 0x0BC4},
            {Opcode.SMSG_CHAR_ENUM, 0x05AF},
            {Opcode.SMSG_CHAR_FACTION_CHANGE, 0x0810},
            {Opcode.SMSG_CHAR_RENAME, 0x0D89},
            {Opcode.SMSG_CLEAR_QUEST_COMPLETED_BITS, 0x1D47},
            {Opcode.SMSG_CLIENT_CONTROL_UPDATE, 0x080E},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x080D},
            {Opcode.SMSG_COIN_REMOVED, 0x0D30},
            {Opcode.SMSG_CONQUEST_FORMULA_CONSTANTS, 0x1342},
            {Opcode.SMSG_CONTACT_LIST, 0x0210},
            {Opcode.SMSG_CONTACT_STATUS, 0x1BEA},
            {Opcode.SMSG_CONVERT_RUNE, 0x1C89},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x0BE2},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x0A26},
            {Opcode.SMSG_CRITERIA_UPDATE_ACCOUNT, 0x0912},
            {Opcode.SMSG_CRITERIA_UPDATE_PLAYER, 0x1904},
            {Opcode.SMSG_DANCE_STUDIO_CREATE_RESULT, 0x178D},
            {Opcode.SMSG_DB_REPLY, 0x1939},
            {Opcode.SMSG_DEFENSE_MESSAGE, 0x1442},
            {Opcode.SMSG_DISPLAY_PROMOTION, 0x151D},
            {Opcode.SMSG_EMOTE, 0x071D},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x0F1E},
            {Opcode.SMSG_EQUIPMENT_SET_SAVED, 0x0027},
            {Opcode.SMSG_FACTION_BONUS_INFO, 0x0928},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x0B1E},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS_GLUE_SCREEN, 0x1540},
            {Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x08A5},
            {Opcode.SMSG_FORCE_RUN_SPEED_CHANGE, 0x08F5},
            {Opcode.SMSG_FORCE_SWIM_SPEED_CHANGE, 0x061A},
            {Opcode.SMSG_GAME_OBJECT_ACTIVATE_ANIM_KIT, 0x038C},
            {Opcode.SMSG_GAMEOBJECT_CUSTOM_ANIM, 0x03EB},
            {Opcode.SMSG_GAMEOBJECT_DESPAWN, 0x0D29},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x128A},
            {Opcode.SMSG_GARRISON_COMPLETE_MISSION_RESULT, 0x0952},
            {Opcode.SMSG_GARRISON_REMOTE_INFO, 0x0151},
            {Opcode.SMSG_GM_TICKET_CASE_STATUS, 0x1D8D},
            {Opcode.SMSG_GM_TICKET_GET_TICKET_RESPONSE, 0x0389},
            {Opcode.SMSG_GM_TICKET_SYSTEM_STATUS, 0x1229},
            {Opcode.SMSG_GOSSIP_COMPLETE, 0x15D1},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x1746},
            {Opcode.SMSG_GOSSIP_POI, 0x011E},
            {Opcode.SMSG_GROUP_LIST, 0x15BE},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_DATA, 0x1866},
            {Opcode.SMSG_GUILD_BANK_LIST, 0x1245},
            {Opcode.SMSG_GUILD_BANK_LOG_QUERY_RESULT, 0x1237},
            {Opcode.SMSG_GUILD_BANK_MONEY_WITHDRAWN, 0x1047},
            {Opcode.SMSG_GUILD_CHALLENGE_UPDATED, 0x1A06},
            {Opcode.SMSG_GUILD_CRITERIA_UPDATE, 0x1208},
            {Opcode.SMSG_GUILD_EVENT_BANK_MONEY_CHANGED, 0x1077},
            {Opcode.SMSG_GUILD_EVENT_PRESENCE_CHANGE, 0x1228},
            {Opcode.SMSG_GUILD_EVENT_RANK_CHANGED, 0x1276},
            {Opcode.SMSG_GUILD_EVENT, 0x1027},
            {Opcode.SMSG_GUILD_INVITE, 0x1025},
            {Opcode.SMSG_GUILD_MEMBER_DAILY_RESET, 0x1015},
            {Opcode.SMSG_GUILD_MOTD, 0x1825},
            {Opcode.SMSG_GUILD_PARTY_STATE_RESPONSE, 0x1225},
            {Opcode.SMSG_GUILD_PERMISSIONS_QUERY_RESULTS, 0x1827},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x1046},
            {Opcode.SMSG_GUILD_RANK, 0x1218},
            {Opcode.SMSG_GUILD_RANKS_UPDATE, 0x1207},
            {Opcode.SMSG_GUILD_RECIPES, 0x1078},
            {Opcode.SMSG_GUILD_REWARDS_LIST, 0x1818},
            {Opcode.SMSG_GUILD_ROSTER, 0x1026},
            {Opcode.SMSG_HIGHEST_THREAT_UPDATE, 0x059A},
            {Opcode.SMSG_HOTFIX_INFO, 0x1D1D},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x0B10},
            {Opcode.SMSG_INITIAL_SETUP, 0x0B07},
            {Opcode.SMSG_INITIAL_SPELLS, 0x0A81},
            {Opcode.SMSG_INIT_CURRENCY,  0x0B06},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x0B04},
            {Opcode.SMSG_INSTANCE_INFO, 0x0DA0},
            {Opcode.SMSG_INVALIDATE_PLAYER, 0x0B37},
            {Opcode.SMSG_INVENTORY_CHANGE_FAILURE, 0x0112},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x010D},
            {Opcode.SMSG_ITEM_PUSH_RESULT, 0x0183},
            {Opcode.SMSG_LEARNED_SPELL, 0x08AB},
            {Opcode.SMSG_LEVELUP_INFO, 0x1BE4},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x0F36},
            {Opcode.SMSG_LFG_JOIN_RESULT, 0x0F72},
            {Opcode.SMSG_LFG_UPDATE_STATUS, 0x07F7},
            {Opcode.SMSG_LIST_INVENTORY, 0x0940},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x1530},
            {Opcode.SMSG_LOG_XPGAIN, 0x1B53},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x09AA},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0B19},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x0FAD},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0B21},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x052D},
            {Opcode.SMSG_LOOT_MONEY_NOTIFY, 0x12A9},
            {Opcode.SMSG_LOOT_REMOVED, 0x0906},
            {Opcode.SMSG_LOOT_RESPONSE, 0x0F8A},
            // 0x15AF sub_839D65 sub_607E4F another loot opcode
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x0B3F},
            {Opcode.SMSG_MAIL_QUERY_NEXT_TIME_RESULT, 0x153D},
            {Opcode.SMSG_MESSAGECHAT, 0x0603},
            {Opcode.SMSG_MINIMAP_PING, 0x07BA},
            {Opcode.SMSG_MONSTER_MOVE, 0x0994},
            {Opcode.SMSG_MOTD, 0x0442},
            //{Opcode.SMSG_MOVE_FEATHER_FALL, }, // Fix me: sub_CB9945
            {Opcode.SMSG_MOVE_GRAVITY_DISABLE, 0x02C6},
            {Opcode.SMSG_MOVE_SET_HOVER, 0x0296},
            {Opcode.SMSG_MOVE_LAND_WALK, 0x13DA},
            //{Opcode.SMSG_MOVE_NORMAL_FALL, }, // Fix me: sub_80C04E
            {Opcode.SMSG_MOVE_ROOT, 0x1B5A},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x01F6},
            {Opcode.SMSG_MOVE_SET_CAN_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x08CE},
            {Opcode.SMSG_MOVE_SET_COLLISION_HEIGHT, 0x008D},
            //{Opcode.SMSG_MOVE_SET_IGNORE_MOVEMENT_FORCES, }, // Fix me: sub_CBA09D
            {Opcode.SMSG_MOVE_TELEPORT, 0x03A6},
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x0BAE},
            {Opcode.SMSG_MOVE_UNSET_CAN_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x00C5},
            {Opcode.SMSG_MOVE_UNSET_IGNORE_MOVEMENT_FORCES, 0x039E},
            {Opcode.SMSG_MOVE_UNSET_HOVER, 0x01A5},
            {Opcode.SMSG_MOVE_UNROOT, 0x08BD},
            {Opcode.SMSG_MOVE_UPDATE_TELEPORT, 0x03D5},
            //{Opcode.SMSG_MOVE_UPDATE_FLIGHT_SPEED, }, // Fix me: sub_CB9F13
            //{Opcode.SMSG_MOVE_UPDATE_FLIGHT_BACK_SPEED, }, // Fix me: sub_CB9F99
            {Opcode.SMSG_MOVE_UPDATE_RUN_SPEED, 0x09AD},
            {Opcode.SMSG_MOVE_UPDATE_PITCH_RATE, 0x13D9},
            {Opcode.SMSG_MOVE_UPDATE_RUN_BACK_SPEED, 0x09DE},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_SPEED, 0x0B95},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_BACK_SPEED, 0x1083},
            {Opcode.SMSG_MOVE_UPDATE_TURN_RATE, 0x08BE},
            {Opcode.SMSG_MOVE_UPDATE_WALK_SPEED, 0x01E5},
            {Opcode.SMSG_MOVE_WATER_WALK, 0x02A6},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x0828},
            {Opcode.SMSG_NEW_WORLD, 0x0206},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x1122},
            {Opcode.SMSG_ON_CANCEL_EXPECTED_RIDE_VEHICLE_AURA, 0x053F},
            {Opcode.SMSG_PAGE_TEXT_QUERY_RESPONSE, 0x05A0},
            {Opcode.SMSG_PARTY_KILL_LOG, 0x1312},
            {Opcode.SMSG_PARTY_MEMBER_STATS, 0x1729},
            {Opcode.SMSG_GROUP_INVITE, 0x0920},
            {Opcode.SMSG_PERIODICAURALOG, 0x0B1B},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x0D0E},
            {Opcode.SMSG_PET_SPELLS, 0x0174},
            {Opcode.SMSG_PLAY_ONE_SHOT_ANIM_KIT, 0x078D},
            {Opcode.SMSG_PLAY_SOUND, 0x02D2},
            {Opcode.SMSG_PLAY_SPELL_VISUAL, 0x1A84},
            {Opcode.SMSG_PLAY_SPELL_VISUAL_KIT, 0x0171},
            {Opcode.SMSG_PLAYED_TIME, 0x038B},
            {Opcode.SMSG_PLAYER_MOVE, 0x0ACE},
            {Opcode.SMSG_PONG, 0x17CA},
            {Opcode.SMSG_POWER_UPDATE, 0x0B27},
            {Opcode.SMSG_PVP_LOG_DATA, 0x1ECA},
            {Opcode.SMSG_QUERY_TIME_RESPONSE, 0x1DB0},
            {Opcode.SMSG_QUESTGIVER_QUEST_LIST, 0x17A5},
            {Opcode.SMSG_QUESTGIVER_OFFER_REWARD, 0x17B2},
            {Opcode.SMSG_QUESTGIVER_REQUEST_ITEMS, 0x17B8},
            {Opcode.SMSG_QUESTGIVER_QUEST_COMPLETE, 0x1773},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x15B3},
            {Opcode.SMSG_QUESTGIVER_STATUS, 0x1567},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0x17C6},
            {Opcode.SMSG_QUEST_NPC_QUERY_RESPONSE, 0x1591},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x1715},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x1547},
            {Opcode.SMSG_QUESTUPDATE_ADD_KILL, 0x1515},
            {Opcode.SMSG_QUESTUPDATE_COMPLETE, 0x1787},
            {Opcode.SMSG_RAID_READY_CHECK, 0x17A9},
            {Opcode.SMSG_RAID_READY_CHECK_COMPLETED, 0x0BC3},
            {Opcode.SMSG_RAID_READY_CHECK_CONFIRM, 0x0A10},
            {Opcode.SMSG_RANDOM_ROLL, 0x1B04},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x0D8F},
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x011D},
            {Opcode.SMSG_REFRESH_SPELL_HISTORY, 0x0A2A},
            {Opcode.SMSG_RESEARCH_SETUP_HISTORY, 0x0A25},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x175A},
            {Opcode.SMSG_REQUEST_CEMETERY_LIST_RESPONSE, 0x059E},
            {Opcode.SMSG_RESUME_COMMS, 0x07C9},
            {Opcode.SMSG_RESUME_TOKEN, 0x0326},
            {Opcode.SMSG_RESUME_CAST_BAR, 0x082C},
            {Opcode.SMSG_SELL_RESPONSE, 0x1352},
            {Opcode.SMSG_SEND_SPELL_CHARGES, 0x1A82},
            {Opcode.SMSG_SEND_MAIL_RESULT, 0x0302},
            {Opcode.SMSG_SEND_SPELL_HISTORY, 0x1933},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x0BCB},
            {Opcode.SMSG_SERVER_MESSAGE, 0x0683},
            {Opcode.SMSG_SET_AI_ANIM_KIT, 0x0335},
            {Opcode.SMSG_SET_CURRENCY, 0x17BE},
            {Opcode.SMSG_SET_FACTION_VISIBLE, 0x138B},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x1884},
            {Opcode.SMSG_SET_FORCED_REACTIONS, 0x09A9},
            {Opcode.SMSG_SET_MAX_WEEKLY_QUANTITY, 0x1489},
            {Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0x02D4},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x113C},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x00D1},
            {Opcode.SMSG_SET_PROFICIENCY, 0x00D3},
            {Opcode.SMSG_SET_TIME_ZONE_INFORMATION, 0x153E},
            {Opcode.SMSG_SET_VIGNETTE, 0x09AC},
            {Opcode.SMSG_SHOWTAXINODES, 0x12A1},
            {Opcode.SMSG_SPELLDAMAGESHIELD, 0x0B4C},
            {Opcode.SMSG_SPELLENERGIZELOG, 0x137C},
            {Opcode.SMSG_SPELLHEALLOG, 0x0114},
            {Opcode.SMSG_SPELLLOGEXECUTE, 0x1823},
            {Opcode.SMSG_SPELLNONMELEEDAMAGELOG, 0x11FB},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x082A},
            {Opcode.SMSG_SPELLDISPELLOG, 0x18A2},
            {Opcode.SMSG_SPELL_FAILED_OTHER, 0x1A03},
            {Opcode.SMSG_SPELL_FAILURE, 0x11DB},
            {Opcode.SMSG_SPELL_GO, 0x1161},
            {Opcode.SMSG_SPELL_MULTISTRIKE_EFFECT, 0x131C},
            {Opcode.SMSG_SPELL_START, 0x0803},
            {Opcode.SMSG_SPELL_UPDATE_CHAIN_TARGETS, 0x0374},
            {Opcode.SMSG_SPLINE_MOVE_GRAVITY_DISABLE, 0x03B2},
            {Opcode.SMSG_SPLINE_MOVE_SET_FLIGHT_SPEED, 0x060C},
            {Opcode.SMSG_SPLINE_MOVE_SET_RUN_BACK_SPEED, 0x0086},
            {Opcode.SMSG_SPLINE_MOVE_SET_RUN_SPEED, 0x1B9A},
            {Opcode.SMSG_SPLINE_MOVE_SET_SWIM_SPEED, 0x098D},
            {Opcode.SMSG_SPLINE_MOVE_SET_WALK_SPEED, 0x01D5},
            {Opcode.SMSG_SPLINE_MOVE_UNSET_HOVER, 0x1959},
            {Opcode.SMSG_STANDSTATE_UPDATE, 0x1311},
            {Opcode.SMSG_START_ELAPSED_TIMERS, 0x093F},
            {Opcode.SMSG_START_MIRROR_TIMER, 0x051E},
            {Opcode.SMSG_SUSPEND_COMMS, 0x076A},
            {Opcode.SMSG_SUSPEND_TOKEN, 0x12A2},
            {Opcode.SMSG_TALENTS_INFO, 0x012D},
            {Opcode.SMSG_SET_ALL_TASK_PROGRESS, 0x1B52},
            {Opcode.SMSG_UPDATE_TASK_PROGRESS, 0x1209},
            {Opcode.SMSG_TAXINODE_STATUS, 0x0338},
            {Opcode.SMSG_TEXT_EMOTE, 0x0383},
            {Opcode.SMSG_THREAT_CLEAR, 0x030F},
            {Opcode.SMSG_THREAT_REMOVE, 0x0F3D},
            {Opcode.SMSG_THREAT_UPDATE, 0x03A9},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x03B1},
            {Opcode.SMSG_TRAINER_LIST, 0x0BA9},
            {Opcode.SMSG_TRANSFER_PENDING, 0x172A},
            {Opcode.SMSG_TRANSFER_ABORTED, 0x03C2},
            {Opcode.SMSG_TRIGGER_CINEMATIC, 0x032F},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x020F},
            {Opcode.SMSG_UNDELETE_CHARACTER_RESPONSE, 0x0344},
            {Opcode.SMSG_UNDELETE_COOLDOWN_STATUS_RESPONSE, 0x0310},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x1520},
            {Opcode.SMSG_UPDATE_OBJECT, 0x122C},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x03EC},
            {Opcode.SMSG_VOICE_SESSION_LEAVE, 0x0403},
            {Opcode.SMSG_VOID_STORAGE_CONTENTS, 0x0108},
            {Opcode.SMSG_VOID_TRANSFER_RESULT, 0x0539},
            {Opcode.SMSG_VOID_STORAGE_TRANSFER_CHANGES, 0x0321},
            {Opcode.SMSG_VOID_ITEM_SWAP_RESPONSE, 0x1131},
            {Opcode.SMSG_XP_GAIN_ENABLED, 0x0FAA},
            {Opcode.SMSG_WAIT_QUEUE_UPDATE, 0x00D4},
            {Opcode.SMSG_WAIT_QUEUE_FINISH, 0x198A},
            {Opcode.SMSG_WARDEN_DATA, 0x0BEC},
            {Opcode.SMSG_WEATHER, 0x073E},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x13DC},
            {Opcode.SMSG_WHO, 0x0601},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x11AC},
            {Opcode.SMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x0B83},
            {Opcode.SMSG_ZONE_UNDER_ATTACK, 0x1401},
        };

        private static readonly BiDictionary<Opcode, int> MiscOpcodes = new BiDictionary<Opcode, int>
        {
        };
    }
}
