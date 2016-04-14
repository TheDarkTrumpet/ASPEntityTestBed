namespace libTestBed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttachmentView : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.AttachmentsView_Insert",
                p => new
                    {
                        stream_id = p.Guid(),
                        name = p.String(maxLength: 255),
                        file_stream = p.Binary(),
                    },
                body:
                    @"INSERT [dbo].[Attachments]([stream_id], [name], [file_stream])
                      VALUES (NEWID(), @name, @file_stream)"
            );
            
            CreateStoredProcedure(
                "dbo.AttachmentsView_Update",
                p => new
                    {
                        stream_id = p.Guid(),
                        name = p.String(maxLength: 255),
                        file_stream = p.Binary(),
                    },
                body:
                    @"UPDATE [dbo].[Attachments]
                      SET [name] = @name
                      WHERE ([stream_id] = @stream_id)"
            );
            
            CreateStoredProcedure(
                "dbo.AttachmentsView_Delete",
                p => new
                    {
                        stream_id = p.Guid(),
                        name = p.String(maxLength: 255),
                    },
                body:
                    @"DELETE [dbo].[Attachments]
                      WHERE ([stream_id] = @stream_id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.AttachmentsView_Delete");
            DropStoredProcedure("dbo.AttachmentsView_Update");
            DropStoredProcedure("dbo.AttachmentsView_Insert");
        }
    }
}
