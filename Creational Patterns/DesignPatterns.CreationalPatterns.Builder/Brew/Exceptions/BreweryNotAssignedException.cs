using System;

namespace DesignPatterns.CreationalPatterns.Builder.Brew.Exceptions
{
    public class BreweryNotAssignedException : Exception
    {
        public BreweryNotAssignedException() : base("No brewery assigned")
        {
        }
    }
}