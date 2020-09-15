using System;

namespace LighthouseAPI
{
    public enum CategoryList 
    {
        Note,
        Checklist
    }

    public class NoteModel
    {
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; } = 0;
        public CategoryList Category { get; set; } = CategoryList.Note;
        public DateTime CreatedOn { get; set; }
        
    }
}