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


/Hospital/Doctor/p32


Please accept this mail as notification that I am resigning from my position as Software Engineer effective From August 30, 2018.

 

Thank you so much for the opportunity to work on this position and your professional guidance and support.

 

If I can be of any assistance during this transition, Kindly accept this as my resignation.
