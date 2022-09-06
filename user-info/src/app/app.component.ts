import { Component } from '@angular/core';
import { PostService } from './post.service';
import { Post } from './post';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  posts: Post[] = [];
  
  constructor(public postService: PostService) { 
  }
  create(fname:string,lname:string,fpath:string): void {
    this.posts = [{firstName : fname, lastName : lname}]
    this.postService.create(this.posts).subscribe(result => {   
      alert(result);
    })  
  } 
}
