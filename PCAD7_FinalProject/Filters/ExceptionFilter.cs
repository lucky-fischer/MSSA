//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;

//namespace PCAD7_Project_MVC.Filters// optional way of handling errors.
//{
//    public class ExceptionFilter : IExceptionFilter
//    {
//        private readonly IHostEnvironment hostEnvironment;
//        public ExceptionFilter(ExceptionContext context)
//        {
//            this.hostEnvironment = hostEnvironment;
//        }
//        public void OnException(ExceptionContext context)
//        {
//            if (!hostEnvironment.IsDevelopment())
//            {
//                return;
//            }
//            context.Result = new ContentResult
//            {
//                Content = context.Exception.Message
//            };
//        }
//    }
//}
