USE DndOverlord;
GO

drop procedure if exists GetCharacterList_01
go

CREATE PROCEDURE GetCharacterList_01
AS
    /*
        Author: Nico Judge
        History

        Date         Version         Update
        -------------------------------------------------
        6/11/2023     1              initial release
     */

    select *
    from dbo.Characters with (nolock)
GO


