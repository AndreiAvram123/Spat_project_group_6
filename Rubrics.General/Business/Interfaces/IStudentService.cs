﻿using Rubrics.General.Business.Models;
using Rubrics.General.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rubrics.Data;

namespace Rubrics.General.Business.Interfaces
{
    public interface IStudentService
    {
        // Tests
        List<StudentFormModel> GetAllTheStudents();
        List<JoinModel> GetTestJoinsUsingLinq();
        Task<IEnumerable<JoinModel>> GetTestJoinsUsingDapper();
        // Methods being implemented
        string CreateRandomPassword(int size, bool lowerCase);
        void CreateNewStudent(StudentFormModel studentFormModel);
        StudentInDbModel GetStudentByEmail(string email);
        Student GetStudentById(int id);
        string GetClassNameById(int id);

        bool DeleteStudentByEmail(string email);
        Task<List<StudentInDbModel>> AllStudentsInTheClass(int teacherClassId);
        void UpdateStudentPassword(StudentInDbModel studentInDb, string hashedPassword);
        void AssignClassToTheStudent(int studentId, int classId);
    }
}
