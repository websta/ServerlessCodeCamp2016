#load "TankInfo.csx"
using System.Net;


public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("tank info function");

    return req.CreateResponse(HttpStatusCode.OK, new TankInfo() {
        owner = "Gerald",
        name = "Gerald's Tank"
    });
}