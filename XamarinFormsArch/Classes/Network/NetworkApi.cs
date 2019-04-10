using System;
using System.Threading.Tasks;
using Refit;
using XamarinFormsArch.Classes.Network.NetworkResponses;
using XamarinFormsArch.Classes.Registeration;

namespace XamarinFormsArch.Classes.Network
{
    public interface NetworkApi
    {
        [Post("/trainingapp/api/users/register")]
        Task<RegisterResponseModel> Register([Body(BodySerializationMethod.UrlEncoded)]RegisterModel model);
    }
}
