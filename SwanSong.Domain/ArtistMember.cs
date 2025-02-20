using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_ArtistMember")]
public class ArtistMember : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public long ArtistId { get; set; }

    public Artist Artist { get; set; }

    public long MemberId { get; set; }

    public Member Member { get; set; }

    public ArtistMember() { }
}