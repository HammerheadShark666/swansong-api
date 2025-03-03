﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_Artist")]
public class Artist : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }

    [Column(TypeName = "varchar(MAX)")]
    public string Description { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Photo { get; set; }

    [Column(TypeName = "int")]
    public int? FormationYear { get; set; }

    [Column(TypeName = "int")]
    public int? DisbandYear { get; set; }

    [Column(TypeName = "int")]
    public int? CountryId { get; set; }

    public Country Country { get; set; }

    public virtual List<Album> Albums { get; set; }

    public ICollection<ArtistMember> ArtistMembers { get; set; } = new HashSet<ArtistMember>();

    public Artist()
    {
        Albums = [];
        Photo = DefaultArtistPhotoFileName;
    }

    public Artist(long id)
    {
        Id = id;
        Albums = [];
        Photo = DefaultArtistPhotoFileName;
    }
}
