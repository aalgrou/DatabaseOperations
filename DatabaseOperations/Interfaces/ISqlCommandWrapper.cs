﻿using System;
using Microsoft.Data.SqlClient;

namespace DatabaseOperations.Interfaces
{
    public interface ISqlCommandWrapper : IDisposable
    {
        SqlCommand Get();
        void AddParameters(SqlParameter[] parameters);
        void SetCommandTimeout(int timeout);
        int ExecuteNonQuery();
    }
}