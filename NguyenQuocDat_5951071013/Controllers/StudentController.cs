﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenQuocDat_5951071013.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfList = new List<StudentInfo>();
            for (long i = 5951071000; i < 5951071011; i++)
            {
                var StudentInfo = new StudentInfo
                {
                    Id = $"Id: {i}",
                    STT = i,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                studentInfList.Add(StudentInfo);
            }
            return studentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Id = $"Id: {id}",
                STT = id,
                DateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
