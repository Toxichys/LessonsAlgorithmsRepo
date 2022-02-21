using System;
using System.Collections.Generic;
using HomeworkAssignmentLibrary.Lesson_1;
using HomeworkAssignmentLibrary.Lesson_2;
using HomeworkAssignmentLibrary.Lesson_3;
using HomeworkAssignmentLibrary.Lesson_4;
using HomeworkAssignmentLibrary.Lesson_5;
using InterfaceHomeworkAssignmentLibrary;

namespace HomeworkAssignmentLibrary
{
    public class HomeworkAssignmentLibrary
    {
        public List<IHomeworkAssignments> GetListHomeworkAssignmentsFromLibrary()
        {
            return new List<IHomeworkAssignments>()
            {
                { new HomeworkAssignment1() },
                { new HomeworkAssignment2() },
                { new HomeworkAssignment3() },
                { new HomeworkAssignment4() },
                { new HomeworkAssignment5() },
                { new HomeworkAssignment6() },
                { new HomeworkAssignment7() }
            };
        }
    }
}
