#load "TankCommand.csx"

using System.Net;


public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("tank command function");
    log.Info(req);

    return req.CreateResponse(HttpStatusCode.OK, new TankCommand() {
        command = "turn-left"
    });
}