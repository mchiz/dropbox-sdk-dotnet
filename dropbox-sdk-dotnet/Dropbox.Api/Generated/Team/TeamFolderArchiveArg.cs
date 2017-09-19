// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The team folder archive arg object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Team.TeamFolderIdArg" />
    public class TeamFolderArchiveArg : TeamFolderIdArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderArchiveArg> Encoder = new TeamFolderArchiveArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderArchiveArg> Decoder = new TeamFolderArchiveArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderArchiveArg" />
        /// class.</para>
        /// </summary>
        /// <param name="teamFolderId">The ID of the team folder.</param>
        /// <param name="forceAsyncOff">Whether to force the archive to happen
        /// synchronously.</param>
        public TeamFolderArchiveArg(string teamFolderId,
                                    bool forceAsyncOff = false)
            : base(teamFolderId)
        {
            this.ForceAsyncOff = forceAsyncOff;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderArchiveArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamFolderArchiveArg()
        {
            this.ForceAsyncOff = false;
        }

        /// <summary>
        /// <para>Whether to force the archive to happen synchronously.</para>
        /// </summary>
        public bool ForceAsyncOff { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderArchiveArg" />.</para>
        /// </summary>
        private class TeamFolderArchiveArgEncoder : enc.StructEncoder<TeamFolderArchiveArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderArchiveArg value, enc.IJsonWriter writer)
            {
                WriteProperty("team_folder_id", value.TeamFolderId, writer, enc.StringEncoder.Instance);
                WriteProperty("force_async_off", value.ForceAsyncOff, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderArchiveArg" />.</para>
        /// </summary>
        private class TeamFolderArchiveArgDecoder : enc.StructDecoder<TeamFolderArchiveArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderArchiveArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderArchiveArg Create()
            {
                return new TeamFolderArchiveArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamFolderArchiveArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "team_folder_id":
                        value.TeamFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "force_async_off":
                        value.ForceAsyncOff = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}