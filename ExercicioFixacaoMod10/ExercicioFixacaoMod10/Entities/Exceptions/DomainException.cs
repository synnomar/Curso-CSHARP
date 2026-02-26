using System;


namespace ExercicioFixacaoMod10.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message) 
        { 
        }
    }
}
