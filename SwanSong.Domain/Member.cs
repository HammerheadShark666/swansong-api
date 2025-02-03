using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_Member")]
public class Member : BaseEntity
{
    private long? artistId;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [ForeignKey("ArtistId")]
    public long? ArtistId
    {
        get
        {
            if (this.artistId == 0)
            {
                this.artistId = null;
                return null;

            }
            return this.artistId;
        }
        set { this.artistId = value; }
    }

    public virtual Artist Artist { get; set; }

    [Column(TypeName = "nvarchar(150)")]
    [Required]
    public string StageName { get; set; }

    [Column(TypeName = "varchar(MAX)")]
    public string Description { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string FirstName { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string Surname { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string MiddleName { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Photo { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? DateOfDeath { get; set; }

    [ForeignKey("BirthPlaceId")]
    public BirthPlace BirthPlace { get; set; }

    [Column(TypeName = "int")]
    public int? BirthPlaceId { get; set; }

    public bool IsSongWriter { get; set; }

    public ICollection<Song> SongsWritten { get; set; }
}
