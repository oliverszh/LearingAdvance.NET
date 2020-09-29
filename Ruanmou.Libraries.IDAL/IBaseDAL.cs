﻿using Ruanmou.Libraries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Libraries.IDAL
{
    public interface IBaseDAL
    {
        T FindT<T>(int id) where T : BaseModel;
        List<T> FindAll<T>() where T : BaseModel;
        bool Add<T>(T t) where T : BaseModel;
        bool Update<T>(T t) where T : BaseModel;
        bool Delete<T>(T t) where T : BaseModel;
    }
}
