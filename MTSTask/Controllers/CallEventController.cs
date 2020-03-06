using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using MTSTask.Filters;
using MTSTask.Models;

namespace MTSTask.Controllers
{
    /// <summary>
    /// Обработка запросов о звонках
    /// </summary>
    [BasicAuthentication]
    [RequireHttps]
    public class CallEventController : ApiController
    {
        private CRMContext db = new CRMContext();

        /// <summary>
        /// Возвращает события АТС
        /// </summary>
        /// <returns></returns>
        public IQueryable<CallEvent> GetCallEvents() // GET: CallEvent
        {
            return db.CallEvents;
        }

        /// <summary>
        /// Возвращает событие по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(CallEvent))]
        public IHttpActionResult GetCallEvent(long id) // GET: api/CallEvent/5
        {
            CallEvent callEvent = db.CallEvents.Find(id);
            if (callEvent == null)
            {
                return NotFound();
            }

            return Ok(callEvent);
        }        

        /// <summary>
        /// Создает событие
        /// </summary>
        [ResponseType(typeof(CallEvent))]
        public IHttpActionResult PostCallEvent(CallEvent callEvent) // POST: CallEvent
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CallEvents.Add(callEvent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = callEvent.Id }, callEvent);
        }

        /// <summary>
        /// Удаляет событие по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(CallEvent))]
        public IHttpActionResult DeleteCallEvent(long id) // DELETE: CallEvent/5
        {
            CallEvent callEvent = db.CallEvents.Find(id);
            if (callEvent == null)
            {
                return NotFound();
            }

            db.CallEvents.Remove(callEvent);
            db.SaveChanges();

            return Ok(callEvent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}