namespace Tranquil.Schema;

public enum ESteamLearnDataType
{
    STEAMLEARN_DATATYPE_INVALID = 0,
    STEAMLEARN_DATATYPE_INT32 = 1,
    STEAMLEARN_DATATYPE_FLOAT32 = 2,
    STEAMLEARN_DATATYPE_BOOL = 3,
    STEAMLEARN_DATATYPE_STRING = 4,
    STEAMLEARN_DATATYPE_OBJECT = 5,
}
public enum ESteammLearnRegisterDataSourceResult
{
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR = 0,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_SUCCESS_CREATED = 1,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_SUCCESS_FOUND = 2,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR_GENERIC = 3,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR_INVALID_NAME = 4,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR_INVALID_VERSION = 5,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR_DATA_CHANGED = 6,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR_DATA_INVALID = 7,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR_FORBIDDEN = 8,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_ERROR_INVALID_TIMESTAMP = 9,
    STEAMLEARN_REGISTER_DATA_SOURCE_RESULT_DISABLED = 10,
}
public enum ESteamLearnCacheDataResult
{
    STEAMLEARN_CACHE_DATA_ERROR = 0,
    STEAMLEARN_CACHE_DATA_SUCCESS = 1,
    STEAMLEARN_CACHE_DATA_ERROR_UNKNOWN_DATA_SOURCE = 2,
    STEAMLEARN_CACHE_DATA_ERROR_UNCACHED_DATA_SOURCE = 3,
    STEAMLEARN_CACHE_DATA_ERROR_INVALID_KEYS = 4,
    STEAMLEARN_CACHE_DATA_ERROR_FORBIDDEN = 5,
    STEAMLEARN_CACHE_DATA_ERROR_INVALID_TIMESTAMP = 6,
    STEAMLEARN_CACHE_DATA_DISABLED = 7,
}
public enum ESteamLearnSnapshotProjectResult
{
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR = 0,
    STEAMLEARN_SNAPSHOT_PROJECT_SUCCESS_STORED = 1,
    STEAMLEARN_SNAPSHOT_PROJECT_SUCCESS_QUEUED = 2,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_INVALID_PROJECT_ID = 3,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_UNKNOWN_DATA_SOURCE = 4,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_INVALID_DATA_SOURCE_KEY = 5,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_MISSING_CACHE_DURATION = 6,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_NO_PUBLISHED_CONFIG = 7,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_FORBIDDEN = 8,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_INVALID_TIMESTAMP = 9,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_INTERNAL_DATA_SOURCE_ERROR = 10,
    STEAMLEARN_SNAPSHOT_PROJECT_DISABLED = 11,
    STEAMLEARN_SNAPSHOT_PROJECT_ERROR_INVALID_PUBLISHED_VERSION = 12,
}
public enum ESteamLearnGetAccessTokensResult
{
    STEAMLEARN_GET_ACCESS_TOKENS_ERROR = 0,
    STEAMLEARN_GET_ACCESS_TOKENS_SUCCESS = 1,
}
public enum ESteamLearnInferenceResult
{
    STEAMLEARN_INFERENCE_ERROR = 0,
    STEAMLEARN_INFERENCE_SUCCESS = 1,
    STEAMLEARN_INFERENCE_ERROR_INVALID_PROJECT_ID = 2,
    STEAMLEARN_INFERENCE_ERROR_MISSING_CACHED_SCHEMA_DATA = 3,
    STEAMLEARN_INFERENCE_ERROR_NO_PUBLISHED_CONFIG = 4,
    STEAMLEARN_INFERENCE_ERROR_FORBIDDEN = 5,
    STEAMLEARN_INFERENCE_ERROR_INVALID_TIMESTAMP = 6,
    STEAMLEARN_INFERENCE_ERROR_INVALID_PUBLISHED_VERSION = 7,
    STEAMLEARN_INFERENCE_ERROR_NO_FETCH_ID_FOUND = 8,
    STEAMLEARN_INFERENCE_ERROR_TOO_BUSY = 9,
}
public enum ESteamLearnInferenceMetadataResult
{
    STEAMLEARN_INFERENCE_METADATA_ERROR = 0,
    STEAMLEARN_INFERENCE_METADATA_SUCCESS = 1,
    STEAMLEARN_INFERENCE_METADATA_ERROR_INVALID_PROJECT_ID = 2,
    STEAMLEARN_INFERENCE_METADATA_ERROR_NO_PUBLISHED_CONFIG = 3,
    STEAMLEARN_INFERENCE_METADATA_ERROR_FORBIDDEN = 4,
    STEAMLEARN_INFERENCE_METADATA_ERROR_INVALID_TIMESTAMP = 5,
    STEAMLEARN_INFERENCE_METADATA_ERROR_INVALID_PUBLISHED_VERSION = 6,
    STEAMLEARN_INFERENCE_METADATA_ERROR_NO_FETCH_ID_FOUND = 7,
}
public record CMsgSteamLearnDataSourceDescObject(List<CMsgSteamLearnDataSourceDescElement> elements) : DotaPacket;
public record CMsgSteamLearnDataSourceDescElement(string name, ESteamLearnDataType data_type, CMsgSteamLearnDataSourceDescObject _object, uint count) : DotaPacket;
public record CMsgSteamLearnDataSource(uint id, string name, uint version, string source_description, CMsgSteamLearnDataSourceDescObject structure, uint structure_crc, uint cache_duration_seconds) : DotaPacket;
public record CMsgSteamLearnDataObject(List<CMsgSteamLearnDataElement> elements) : DotaPacket;
public record CMsgSteamLearnDataElement(string name, bool unused2, bool unused3, bool unused4, bool unused5, bool unused6, bool unused7, bool unused8, bool unused9, bool unused10, bool unused11, bool unused12, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, List<int> data_int32s, List<float> data_floats, List<bool> data_bools, List<string> data_strings, List<CMsgSteamLearnDataObject> data_objects) : DotaPacket;
public record CMsgSteamLearnData(uint data_source_id, List<ulong> keys, CMsgSteamLearnDataObject data_object) : DotaPacket;
public record CMsgSteamLearnDataList(List<CMsgSteamLearnData> data) : DotaPacket;
public record CMsgSteamLearn_RegisterDataSource_Request(string access_token, bool unused2, CMsgSteamLearnDataSource data_source) : DotaPacket;
public record CMsgSteamLearn_RegisterDataSource_Response(ESteammLearnRegisterDataSourceResult result, CMsgSteamLearnDataSource data_source) : DotaPacket;
public record CMsgSteamLearn_CacheData_Request(string access_token, bool unused2, CMsgSteamLearnData data) : DotaPacket;
public record CMsgSteamLearn_CacheData_Response(ESteamLearnCacheDataResult cache_data_result) : DotaPacket;
public record CMsgSteamLearn_SnapshotProject_Request(string access_token, bool unused2, uint project_id, List<ulong> keys, List<CMsgSteamLearnData> data, uint pending_data_limit_seconds, uint published_version) : DotaPacket;
public record CMsgSteamLearn_SnapshotProject_Response(ESteamLearnSnapshotProjectResult snapshot_result) : DotaPacket;
public record CMsgSteamLearn_BatchOperation_Request(List<CMsgSteamLearn_CacheData_Request> cache_data_requests, List<CMsgSteamLearn_SnapshotProject_Request> snapshot_requests, List<CMsgSteamLearn_Inference_Request> inference_requests) : DotaPacket;
public record CMsgSteamLearn_BatchOperation_Response(List<CMsgSteamLearn_CacheData_Response> cache_data_responses, List<CMsgSteamLearn_SnapshotProject_Response> snapshot_responses, List<CMsgSteamLearn_Inference_Response> inference_responses) : DotaPacket;
public record CMsgSteamLearnAccessTokens(string register_data_source_access_token, List<CMsgSteamLearnAccessTokens.CacheDataAccessToken> cache_data_access_tokens, List<CMsgSteamLearnAccessTokens.SnapshotProjectAccessToken> snapshot_project_access_tokens, List<CMsgSteamLearnAccessTokens.InferenceAccessToken> inference_access_tokens) : DotaPacket
{
    public record CacheDataAccessToken(uint data_source_id, string access_token);
    public record SnapshotProjectAccessToken(uint project_id, string access_token);
    public record InferenceAccessToken(uint project_id, string access_token);
}
public record CMsgSteamLearn_GetAccessTokens_Request(uint appid) : DotaPacket;
public record CMsgSteamLearn_GetAccessTokens_Response(ESteamLearnGetAccessTokensResult result, CMsgSteamLearnAccessTokens access_tokens) : DotaPacket;
public record CMsgSteamLearn_Inference_Request(string access_token, bool unused2, uint project_id, uint published_version, uint override_train_id, CMsgSteamLearnDataList data, List<float> additional_data) : DotaPacket;
public record CMsgSteamLearn_InferenceMetadata_Request(string access_token, bool unused2, uint project_id, uint published_version, uint override_train_id) : DotaPacket;
public record CMsgSteamLearn_InferenceMetadataBackend_Request(uint project_id, uint fetch_id) : DotaPacket;
public record CMsgSteamLearn_InferenceMetadata_Response(ESteamLearnInferenceMetadataResult inference_metadata_result, CMsgSteamLearn_InferenceMetadata_Response.RowRange row_range, List<CMsgSteamLearn_InferenceMetadata_Response.Range> ranges, List<CMsgSteamLearn_InferenceMetadata_Response.StdDev> std_devs, List<CMsgSteamLearn_InferenceMetadata_Response.CompactTable> compact_tables, List<CMsgSteamLearn_InferenceMetadata_Response.KMeans> kmeans, CMsgSteamLearn_InferenceMetadata_Response.SnapshotHistogram snapshot_histogram, List<CMsgSteamLearn_InferenceMetadata_Response.AppInfoEntry> app_info, List<CMsgSteamLearn_InferenceMetadata_Response.SequenceTable> sequence_tables) : DotaPacket
{
    public record RowRange(ulong min_row, ulong max_row);
    public record Range(string data_element_path, float min_value, float max_value);
    public record StdDev(string data_element_path, float mean, float std_dev);
    public record CompactTable(string name, List<CMsgSteamLearn_InferenceMetadata_Response.CompactTable.MapValuesEntry> map_values, List<CMsgSteamLearn_InferenceMetadata_Response.CompactTable.MapMappingsEntry> map_mappings)
    {
        public record Entry(uint value, uint mapping, ulong count);
        public record MapValuesEntry(uint key, CMsgSteamLearn_InferenceMetadata_Response.CompactTable.Entry value);
        public record MapMappingsEntry(uint key, CMsgSteamLearn_InferenceMetadata_Response.CompactTable.Entry value);
    }
    public record SequenceTable(string name, List<CMsgSteamLearn_InferenceMetadata_Response.SequenceTable.MapValuesEntry> map_values, List<CMsgSteamLearn_InferenceMetadata_Response.SequenceTable.MapMappingsEntry> map_mappings, ulong total_count)
    {
        public record Entry(List<uint> values, uint crc, uint count);
        public record MapValuesEntry(uint key, CMsgSteamLearn_InferenceMetadata_Response.SequenceTable.Entry value);
        public record MapMappingsEntry(string key, CMsgSteamLearn_InferenceMetadata_Response.SequenceTable.Entry value);
    }
    public record KMeans(string name, List<CMsgSteamLearn_InferenceMetadata_Response.KMeans.Cluster> clusters)
    {
        public record Cluster(float x, float y, float radius, float radius_75pct, float radius_50pct, float radius_25pct);
    }
    public record SnapshotHistogram(float min_value, float max_value, uint num_buckets, List<uint> bucket_counts);
    public record AppInfo(string country_allow, string country_deny, bool platform_win, bool platform_mac, bool platform_linux, bool adult_violence, bool adult_sex);
    public record AppInfoEntry(uint key, CMsgSteamLearn_InferenceMetadata_Response.AppInfo value);
}
public record CMsgSteamLearn_InferenceBackend_Response(List<CMsgSteamLearn_InferenceBackend_Response.Output> outputs) : DotaPacket
{
    public record Sequence(List<float> value);
    public record RegressionOutput(float value);
    public record BinaryCrossEntropyOutput(float value);
    public record MutliBinaryCrossEntropyOutput(List<float> weight, List<float> value, List<CMsgSteamLearn_InferenceBackend_Response.Sequence> value_sequence);
    public record CategoricalCrossEntropyOutput(List<float> weight, List<float> value, List<CMsgSteamLearn_InferenceBackend_Response.Sequence> value_sequence);
    public record Output(CMsgSteamLearn_InferenceBackend_Response.BinaryCrossEntropyOutput binary_crossentropy, CMsgSteamLearn_InferenceBackend_Response.CategoricalCrossEntropyOutput categorical_crossentropy, CMsgSteamLearn_InferenceBackend_Response.MutliBinaryCrossEntropyOutput multi_binary_crossentropy, CMsgSteamLearn_InferenceBackend_Response.RegressionOutput regression);
}
public record CMsgSteamLearn_Inference_Response(ESteamLearnInferenceResult inference_result, CMsgSteamLearn_InferenceBackend_Response backend_response, List<ulong> keys) : DotaPacket;
