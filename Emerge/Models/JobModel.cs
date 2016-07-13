using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emerge.Models
{
    public class Model_Job
    {
        // [Required]
        [Display(Name = "Job ID")]
        public Guid JobID { get; set; }

        
        [Display(Name = "Uploaded by")]
        public Guid UserID { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public String Title { get; set; }

        [Required]
        [Display(Name = "Category")]
        public String Category { get; set; }

        [Required]
        [Display(Name = "Sub Category")]
        public String SubCategory { get; set; }

       
        [Display(Name = "Description")]
        public String JobDescription { get; set; }

        [Display(Name = "Requirements")]
        public String Requirements { get; set; }

        // [Required]
        [Display(Name = "Version Date")]
        public DateTime EntryVersionDate { get; set; }

        // [Required]
        [Display(Name = "Change Performed")]
        public string EntryChangePerformed { get; set; }

        // [Required]
        [Display(Name = "Reason For Change")]
        public string EntryReasonForChange { get; set; }

        //[Required]
        [Display(Name = "Is Current")]
        public bool EntryIsCurrent { get; set; }

        [Display(Name = "Has Photos")]
        public bool HasPhotos { get; set; }

        [Display(Name = "Product Picture")]
        public HttpPostedFileBase JobPicture { get; set; }


        [Display(Name = "Picture ID")]
        public Guid PictureID { get; set; }
        

        [Display(Name = "Picture Link")]
        public string PictureLink { get; set; }



    }
}