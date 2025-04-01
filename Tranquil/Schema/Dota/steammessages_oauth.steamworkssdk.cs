using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record COAuthToken_ImplicitGrantNoPrompt_Request(string clientid) : DotaPacket;
public record COAuthToken_ImplicitGrantNoPrompt_Response(string access_token, string redirect_uri) : DotaPacket;
