using System;

namespace InterfaceHomeworkAssignmentLibrary
{
    public interface IHomeworkAssignments
    {
        string HomeworkID { get; }
        string HomeworkName { get; }
        void HomeworkTest();
    }
}
