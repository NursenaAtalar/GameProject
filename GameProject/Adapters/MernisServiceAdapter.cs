using GameProject.Business.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidateService
    {
        public bool UserValidate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(user.IdentityNumber, user.FirstName, user.LastName, user.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

        