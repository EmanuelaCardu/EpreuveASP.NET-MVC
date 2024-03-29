﻿namespace ASP_Epreuve.Handlers
{
    public class SessionManager
    {
        protected readonly ISession _session;

        public SessionManager(IHttpContextAccessor httpContext) //Injection de dépendance de l'HttpContext car inaccessible hors controller
        {
            _session = httpContext.HttpContext.Session;
        }
    }
}
