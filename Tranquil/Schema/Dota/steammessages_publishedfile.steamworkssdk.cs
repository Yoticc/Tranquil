using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CPublishedFile_Subscribe_Request(ulong publishedfileid, uint list_type, int appid, bool notify_client) : DotaPacket;
public record CPublishedFile_Subscribe_Response : DotaPacket;
public record CPublishedFile_Unsubscribe_Request(ulong publishedfileid, uint list_type, int appid, bool notify_client) : DotaPacket;
public record CPublishedFile_Unsubscribe_Response : DotaPacket;
public record CPublishedFile_Publish_Request(uint appid, uint consumer_appid, string cloudfilename, string preview_cloudfilename, string title, string file_description, uint file_type, string consumer_shortcut_name, string youtube_username, string youtube_videoid, uint visibility, string redirect_uri, List<string> tags, string collection_type, string game_type, string url) : DotaPacket;
public record CPublishedFile_Publish_Response(ulong publishedfileid, string redirect_uri) : DotaPacket;
public record CPublishedFile_GetDetails_Request(List<long> SF2publishedfileids, bool includetags, bool includeadditionalpreviews, bool includechildren, bool includekvtags, bool includevotes, bool unused7, bool short_description) : DotaPacket;
public record PublishedFileDetails(uint result, ulong publishedfileid, long SF2creator, uint creator_appid, uint consumer_appid, uint consumer_shortcutid, string filename, ulong file_size, ulong preview_file_size, string file_url, string preview_url, string youtubevideoid, string url, long SF2hcontent_file, long SF2hcontent_preview, string title, string file_description, string short_description, uint time_created, uint time_updated, uint visibility, uint flags, bool workshop_file, bool workshop_accepted, bool show_subscribe_all, int num_comments_developer, int num_comments_public, bool banned, string ban_reason, long SF2banner, bool can_be_deleted, bool incompatible, string app_name, uint file_type, bool can_subscribe, uint subscriptions, uint favorited, uint followers, uint lifetime_subscriptions, uint lifetime_favorited, uint lifetime_followers, uint views, uint image_width, uint image_height, string image_url, bool spoiler_tag, uint shortcutid, string shortcutname, uint num_children, uint num_reports, List<PublishedFileDetails.Preview> previews, List<PublishedFileDetails.Tag> tags, List<PublishedFileDetails.Child> children, List<PublishedFileDetails.KVTag> kvtags, PublishedFileDetails.VoteData vote_data, uint time_subscribed) : DotaPacket
{
    public record Tag(string tag, bool adminonly);
    public record Preview(ulong previewid, uint sortorder, string url, uint size, string filename, string youtubevideoid);
    public record Child(ulong publishedfileid, uint sortorder, uint file_type);
    public record KVTag(string key, string value);
    public record VoteData(float score, uint votes_up, uint votes_down);
}
public record CPublishedFile_GetDetails_Response(List<PublishedFileDetails> publishedfiledetails) : DotaPacket;
public record CPublishedFile_GetUserFiles_Request(uint appid, bool unused2, uint page, uint numperpage, bool unused5, string sortmethod, bool totalonly, bool unused8, uint privacy, bool ids_only, List<string> requiredtags, List<string> excludedtags) : DotaPacket;
public record CPublishedFile_GetUserFiles_Response(uint total, uint startindex, List<PublishedFileDetails> publishedfiledetails, List<CPublishedFile_GetUserFiles_Response.App> apps) : DotaPacket
{
    public record App(uint appid, string name, uint shortcutid, bool _private);
}
public record CPublishedFile_Update_Request(uint appid, long SF2publishedfileid, string title, string file_description, uint visibility, List<string> tags, string filename, string preview_filename) : DotaPacket;
public record CPublishedFile_Update_Response : DotaPacket;
public record CPublishedFile_RefreshVotingQueue_Request(uint appid, uint matching_file_type, List<string> tags, bool match_all_tags, List<string> excluded_tags, uint desired_queue_size) : DotaPacket;
public record CPublishedFile_RefreshVotingQueue_Response : DotaPacket;
