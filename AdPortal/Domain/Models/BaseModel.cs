﻿using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    [DataContract]
    public class BaseModel : IBaseModel
    {

        public BaseModel()
        {
            Id = Guid.NewGuid();
            
        }
        public Guid Id { get; set; }
        
    }
   
}
