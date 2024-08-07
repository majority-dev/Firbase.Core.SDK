﻿namespace Firebase.SDK.Firebase.Database
{
    #region Namespace Imports

    using System;

    #endregion


    public interface IFirebaseDatabase
    {
        IDatabaseRef Ref(string path);

        IDatabaseRef Ref(string path, QueryBuilder queryBuilder);
    }
}