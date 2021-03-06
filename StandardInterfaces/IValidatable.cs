﻿namespace StandardInterfaces
{
    public interface IValidatable
    {
        bool IsValid();
    }
    public interface IValidatable<in T>
    {
        bool IsValid(T validator);
    }
}
