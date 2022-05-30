using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string ErrorMessage{ get; set; }

        public ServiceResult(bool isSucces, T data, string errorMessage)
        {
            IsSuccess = isSucces;
            Data = data;
            ErrorMessage = errorMessage;
        }

        public ServiceResult() 
        {
        }

    }
}
