using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace HelloName.Conventions
{
    public class PashaConventions : IControllerModelConvention
    {
        const string contollerName = "ControllerPasha";
        public void Apply(ControllerModel controllerModel)
        {
            controllerModel.ControllerName = controllerModel.ControllerName.Replace(contollerName, string.Empty);
        }
    }
}