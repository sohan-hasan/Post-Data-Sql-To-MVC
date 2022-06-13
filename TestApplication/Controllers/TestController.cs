using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult UpdateLastLocationCache()
        {
            //bool isCacheUpdated = false;
            //try
            //{
            //    PointRepository _pointRepository = new PointRepository();
            //    List<NewMovePointModel> newMovePointModels = _pointRepository.GetNewPointList();
            //    isCacheUpdated = Mapping.HtTruckCollectionMapping.UpdateLastLocationCache("lastLocationList", newMovePointModels);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //return await Task.FromResult(isCacheUpdated);
            return null;
        }
    }
}
