using GraphQL.Types;
using GraphQLNetExample.EntityFramework;

namespace GraphQLNetExample.Notes;

public class NotesQuery : ObjectGraphType
{
    public NotesQuery()
    {
        Field<ListGraphType<NoteType>>("notes", resolve: context => 
        {
            var notesContext = context.RequestServices.GetRequiredService<NotesContext>();
            return notesContext.Note.ToList();
        });
    }
}