1. Statup
_TYPE:_ Programm start
_DESCRIPTION:_ Os ir User starts the application
_TRIGGER:_ PC starts or user restarts the app
_RESULT:_ The application has started (lul)
_ACTORS:_ User or Os
_INPUT INFO:_ Storage file
_PRECONDITIONS:_ none
_POSTCONDITIONS:_ none
_STEPS:_ 1. User or Os starts the application
         2. Application reads the storage file from the disk
         3. Application creates workers
         4. Application creates a timer
