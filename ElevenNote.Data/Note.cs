using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; }
    }
}

/* Notes on GUIDS
 * 
 * GUID - Global Unique Identifier
 * Global, as in the world
 * Computer that this is running on is capable of generating
 * Identity framework identifiers users by GUID. It's a hexadecimal character.
 * Once user is created, it creates a GUID tied to the account.
 * Performance of the database. Inserting a new row, we want something that's incremental.
 * It's faster to add something to the end of the list, not the middle.
 * 
 * VALUE TYPES VS. REFERENCE TYPES
 * DateTimeOffset is a value type. They can't be null.
 * Objects are a reference type. They can't be null.
 * Adding the question mark to ModifiedUtc allows a value type to be null.
 */