using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("CorpusContent", Schema = "mifi")]
    public partial class CorpusContent
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("corpusId")]
        public long CorpusId { get; set; }
        [Column("classRoom")]
        public long ClassRoom { get; set; }

        [ForeignKey(nameof(CorpusId))]
        [InverseProperty("CorpusContents")]
        public virtual ClassRoom Corpus { get; set; }
        [ForeignKey(nameof(CorpusId))]
        [InverseProperty(nameof(Corps.CorpusContents))]
        public virtual Corps CorpusNavigation { get; set; }
    }
}
