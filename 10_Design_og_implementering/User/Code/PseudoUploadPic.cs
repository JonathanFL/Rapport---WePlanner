public Task<IActionResult> UploadFile(file)
{
    var User = database.FindUser();
    
    //Validation
    if(file.size == 0)
        return "No file selected";
        
    if(file.size > MAXSIZE)
        return "File too big";
        
    if(file.type is neither of ".gif", ".jpeg", "jpg" or "png")
        return "Incorrect filetype";
    
    //Construct filepath    
    string path = ProjectDirectory + "wwwroot/Images/ProfilePics" + fileName + TimeStamp;
    
    //Save file to directory
    if(User alreaedy has profile picture)
        Profilepicture.Delete();
        
    WriteFile(file, path);
    
    //Update user
    User.PBUrl = fileName;
    
    return;
}