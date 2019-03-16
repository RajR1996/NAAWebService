using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NAA.Data;
using NAA.Data.BEANS;

/// <summary>
/// Summary description for ApplicationsWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ApplicationsWebService : System.Web.Services.WebService
{
    private NAA.Services.IService.IApplicationService _applicationService;

    public ApplicationsWebService()
    {
        _applicationService = new NAA.Services.Service.ApplicationService();
    }

    // [WebMethod]
    // public string HelloWorld()
    // {
    //     return "Hello World";
    // }

    // Old UniversityApplications method which didn't utilise BEANS.

    //[WebMethod]
    //public List<Application> GetUniversityApplications(int UniversityId)
    //{
    //    return _applicationService.GetUniversityApplications(UniversityId).ToList();
    //}

    // Methods using BEANS to output all applications for a specific university
    [WebMethod]
    public List<UniversityApplicationsBEAN> GetUniversityApplications(int UniversityId)
    {
        return _applicationService.GetUniversityApplications(UniversityId).ToList();
    }

    // Old StudentApplication method which didn't utilise BEANS.
    //[WebMethod]
    //public Application GetOneApplication(int ApplicationId)
    //{
    //    return _applicationService.GetOneApplication(ApplicationId);
    //}

    [WebMethod]
    public StudentApplicationBEAN GetOneUniApplication(int ApplicationId)
    {
        return _applicationService.GetOneUniApplication(ApplicationId);
    }

    // Make an offer for a student application
    [WebMethod]
    public void UpdateUniversityOffer(int ApplicationId, string UniversityOffer)
    {
        _applicationService.UpdateUniversityOffer(ApplicationId, UniversityOffer);
    }
    

}
