﻿using System;
using System.Collections.Generic;

namespace tets_bogdan.Models
{
    public partial class Team
    {
        public Team()
        {
            ScoreTables = new HashSet<ScoreTable>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? TrainerId { get; set; }
        public int? FirstParticipantId { get; set; }
        public int? SecondParticipantId { get; set; }
        public int? SelectedStageId { get; set; }
        public int? RobotId { get; set; }
        public int? BlocksScoreId { get; set; }

        public virtual ScoreTable? BlocksScore { get; set; }
        public virtual Participant? FirstParticipant { get; set; }
        public virtual Robot? Robot { get; set; }
        public virtual Participant? SecondParticipant { get; set; }
        public virtual Competition? SelectedStage { get; set; }
        public virtual Trainer? Trainer { get; set; }
        public virtual ICollection<ScoreTable> ScoreTables { get; set; }
    }
}
