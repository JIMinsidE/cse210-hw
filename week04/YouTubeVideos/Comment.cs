using System;
using System.Collections.Generic;

public class Comment
{
    public string _commentText { get; set; }
    public string _commenterName { get; set; }
    public Comment(string commentText, string commenterName)
    {
        _commentText = commentText;
        _commenterName = commenterName;
    }


    // private string _commentText;
    // private string _commenterName;

    // public string CommentText
    // {
    //     get { return _commentText; }
    //     set { _commentText = value; }
    // }

    // public string CommenterName
    // {
    //     get { return _commenterName; }
    //     set { _commenterName = value; }
    // }
    // public Comment(string commentText)
    // {
    //     _commentText = commentText;
    //     _commenterName = string.Empty;
    // }
    // public Comment(string commentText, string commenterName)
    // {
    //     _commentText = commentText;
    //     _commenterName = commenterName;
    // }
} 