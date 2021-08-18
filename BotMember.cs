﻿// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Konata.Core
{
    public class BotMember
    {
        /// <summary>
        /// Member uin
        /// </summary>
        public uint Uin { get; set; }

        /// <summary>
        /// Member name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Member nick name
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Member special title
        /// </summary>
        public string SpecialTitle { get; set; }

        /// <summary>
        /// Member special title expird time
        /// </summary>
        public uint SpecialTitleExpiredTime { get; set; }

        /// <summary>
        /// Member age
        /// </summary>
        public uint Age { get; set; }

        /// <summary>
        /// Member face Id
        /// </summary>
        public byte FaceId { get; set; }

        /// <summary>
        /// Member gender
        /// </summary>
        public byte Gender { get; set; }

        /// <summary>
        /// Member birth
        /// </summary>
        public int Birth { get; set; }

        /// <summary>
        /// Member level
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Member join time
        /// </summary>
        public uint JoinTime { get; set; }

        /// <summary>
        /// Member last speak time
        /// </summary>
        public uint LastSpeakTime { get; set; }

        /// <summary>
        /// Member is admin
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Mute timestamp
        /// </summary>
        public uint MuteTimestamp { get; set; }

        public BotMember()
        {
            Name = "";
            NickName = "";
        }
    }
}
