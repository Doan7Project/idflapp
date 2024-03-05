﻿using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class StandardAnswerModel : BaseInterface
    {
        public string? Question { get; set; }
        public Guid? StandardQuestionId { get; set; }
        public bool IsYesNo { get; set; }
        public Guid? ProjectId { get; set; }
        public ProjectModel? ProjectModel { get; set; }
    }
}
