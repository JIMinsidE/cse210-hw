using System;
using System.Collections.Generic;
public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }

    //previous disign
    //     private string _title;
    //     private string _author;
    //     private int _length;
    //     private List<Comment> _comments = new List<Comment>();
    //     public Video(string title, string author, int length)
    //     {
    //         _title = title;
    //         _author = author;
    //         _length = length;

    //     }
    //     public string Title
    //     {
    //         get { return _title; }
    //         set { _title = value; }
    //     }
    //     public string Author
    //     {
    //         get { return _author; }
    //         set { _author = value; }
    //     }
    //     public int Length
    //     {
    //         get { return _length; }
    //         set { _length = value; }
    //     }
    //     public List<Comment> Comments
    //     {
    //         get { return _comments; }
    //}
}