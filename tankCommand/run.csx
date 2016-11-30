using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("tank command function");

    return req.CreateResponse(HttpStatusCode.OK, "Hello tank command");
}