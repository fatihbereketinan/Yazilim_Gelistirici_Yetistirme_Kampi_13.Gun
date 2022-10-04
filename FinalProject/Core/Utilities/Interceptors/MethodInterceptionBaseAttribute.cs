﻿
using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor //using Castle.DynamicProxy
    {
        public int Priority { get; set; }  //Priority: öncelik, hangisi önce çalışsın

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
