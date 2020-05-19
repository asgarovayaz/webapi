using System;
using System.Collections.Generic;
using System.Linq;
using WebApiSkeleton.Models.Entities;
using WebApiSkeleton.Models.Extentions;

namespace WebApiSkeleton.Core.Domain
{
    public class Project
    {
        #region Projects information

        public long Id { get; set; }

        public string Code => Id == 0 ? "" : Discipline.Code() + Id;

        public string Name { get; set; }

        public string Country { get; set; }

        public string Location { get; set; }

        public Disciplines Discipline { get; set; }
 
        public string BankRequisites { get; set; }

        public int Currency { get; set; }

        public int Status { get; set; }

        public bool isAccomontation { get; set; }

        public bool isMeal { get; set; }
        
        public bool isMusic { get; set; }

        #endregion


        #region Project Deadlines
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? WebApiSkeletonFillingStartDate { get; set; }
        public DateTime? WebApiSkeletonFillingEndDate { get; set; }
        public DateTime? AccommodationFillingStartDate { get; set; }
        public DateTime? AccommodationFillingEndDate { get; set; }
        public DateTime? AccommodationLimitStartDate { get; set; }
        public DateTime? AccommodationLimitEndDate { get; set; }
        public DateTime? AccommodationRoomFillingStartDate { get; set; }
        public DateTime? AccommodationRoomFillingEndDate { get; set; }
        public DateTime? MealsFillingStartDate { get; set; }
        public DateTime? MealsFillingEndDate { get; set; }
        public DateTime? MealsLimitStartDate { get; set; }
        public DateTime? MealsLimitEndDate { get; set; }
        public DateTime? VisaFillingStartDate { get; set; }
        public DateTime? VisaFillingEndDate { get; set; }
        public DateTime? ArrivalFillingStartDate { get; set; }
        public DateTime? ArrivalFillingEndDate { get; set; }
        public DateTime? DepartureFillingStartDate { get; set; }
        public DateTime? DepartureFillingEndDate { get; set; }
        public DateTime? PhotoFillingStartDate { get; set; }
        public DateTime? PhotoFillingEndDate { get; set; }
        public DateTime? MusicFillingStartDate { get; set; }
        public DateTime? MusicFillingEndDate { get; set; }
        #endregion


    }
}
