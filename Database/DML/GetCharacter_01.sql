
USE DndOverlord;
GO


drop procedure if exists GetCharacter_01
go

CREATE PROCEDURE GetCharacter_01(
    @CharacterID bigint
)
AS
    /*
        Author: Nico Judge
        History

        Date         Version         Update
        -------------------------------------------------
        6/11/2023     1              initial release
     */

    select *
    from Characters with (nolock)
    where CharacterID = @CharacterID
GO


