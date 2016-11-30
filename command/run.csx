#load "TankCommand.csx"

using System.Net;


public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("tank command function");

    return req.CreateResponse(HttpStatusCode.OK, new TankCommand() {
        command = "turn-left"
    });
}