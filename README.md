# Fora

Hej Albin!

Main-branch är den du kan rätta ifall det finns andra branches.

Du kan logga in som admin med:
- Username: admin
- Password: admin

Dom andra användarnas uppgifter kan du hitta i Server.UserDbContext.

# Database

Vi har gjort en databas för Identity (UserDb) och en för Fora (ForaDb). I Server.Program.cs så har vi ställt in så att båda databaserna byggs om varje gång programmet körs så länge det inte finns någon migration. Om du vill behålla data så kan du ändra från *EnsureCreated()* till *Migrate()* och köra Add-Migration för varje context före programmet körs.
