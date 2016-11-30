#load "Models/RequestModel.csx"
#load "Models/ResponseModel.csx"


using System.Net;


public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("tank command function");
    log.Info(req);
    for (var item in req) {
        log.Info(var);
    }

    RequestModel request;
    try
    {
        request = await req.Content.ReadAsStringAsync();   
        log.Info(request.matchId); 
    }
    catch (System.Exception)
    {
        throw;
    }
    
    return req.CreateResponse(HttpStatusCode.OK, new ResponseModel() {
        command = "turn-left"
    });
}