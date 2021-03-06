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
    /// <para>The team folder rename arg object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Team.TeamFolderIdArg" />
    public class TeamFolderRenameArg : TeamFolderIdArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderRenameArg> Encoder = new TeamFolderRenameArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderRenameArg> Decoder = new TeamFolderRenameArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderRenameArg" />
        /// class.</para>
        /// </summary>
        /// <param name="teamFolderId">The ID of the team folder.</param>
        /// <param name="name">New team folder name.</param>
        public TeamFolderRenameArg(string teamFolderId,
                                   string name)
            : base(teamFolderId)
        {
            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            this.Name = name;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderRenameArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamFolderRenameArg()
        {
        }

        /// <summary>
        /// <para>New team folder name.</para>
        /// </summary>
        public string Name { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderRenameArg" />.</para>
        /// </summary>
        private class TeamFolderRenameArgEncoder : enc.StructEncoder<TeamFolderRenameArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderRenameArg value, enc.IJsonWriter writer)
            {
                WriteProperty("team_folder_id", value.TeamFolderId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderRenameArg" />.</para>
        /// </summary>
        private class TeamFolderRenameArgDecoder : enc.StructDecoder<TeamFolderRenameArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderRenameArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderRenameArg Create()
            {
                return new TeamFolderRenameArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamFolderRenameArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "team_folder_id":
                        value.TeamFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
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
