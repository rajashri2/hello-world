routes.MapRoute(
    name: "MyRoute",
    url: "Hospital/Doctor/{patientId}",
    defaults: new
    {
        controller = "HospitalHandler",
        action = "ProcessPatient",
        patientId = UrlParameter.Optional
    },
    new {id = @"\d+"}
);

routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new
    {
        controller = "Home",
        action = "Index",
        id = UrlParameter.Optional
    }
);
