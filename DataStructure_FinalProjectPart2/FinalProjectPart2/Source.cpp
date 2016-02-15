#include<iostream>
#include<iomanip>
#include<string>
#include <algorithm> 
using namespace std;
//struct of student
struct Student
{
	int _num;
	string _name;
	//default constructor
	Student(const int num,const string name) : _num(num), _name(name) {};
	Student (): _num(000), _name("") {};	   
	~Student() {};		
};
//struct of a node
struct Node
{
 typedef Student Element;
 Element data;
 Node * link;
 };
 
Student * createStudent();
//insert:head,random,tail
Node * list_head_insert( Node* & head_ptr, const Node::Element  & entry);
void insert_list_random(Node* & head_ptr);
Node * list_tail_insert( Node * previous_ptr, const Node::Element & entry);
//search
void search( Node* & head_ptr, int num);
//remove:head,random,tail
void list_head_remove( Node * & head_ptr);
void remove_list_random(Node* & head_ptr);
void list_tail_remove( Node * & head_ptr);
//display
void list_contents(Node   *   & head_ptr);
//copy
void list_copy(Node* source_ptr, Node *& new_head_ptr, Node *& new_tail_ptr);
Node * list_insert( Node * previous_ptr, const Node::Element & entry);
//clear
void list_clear( Node *& head_ptr);
size_t list_length(Node  * head_ptr);

Node  * head_ptr = NULL; 
Node  * tail_ptr = NULL; 
Node  * current_ptr=NULL;

int main()
{   	
	int mainChoice;
    int subMainChoice;
	Student * s = new Student();
	int num;	
	Node * source_ptr    =   head_ptr ;
	Node * new_head_ptr  =   NULL;
	Node * new_tail_ptr  =   NULL;
	tail_ptr             =   head_ptr;
	do
	{
	 system("cls");
	 cout<<"\n\n\n\n			Welcome to Student Management    "<<endl<<endl<<endl;
	 cout<<"	 1- Add a Student"<<endl;
	 cout<<"	 2- Search for a Student "<<endl;
	 cout<<"	 3- Remove a Student"<<endl;
	 cout<<"	 4- Display the original linked list of Students "<<endl;
	 cout<<"	 5- Copy the linked list of Students "<<endl;
	 cout<<"	 6- Display the linked list backup of Students "<<endl;
	 cout<<"	 7- Delete the original linked list of Students "<<endl;
	 cout<<"	 8- Exit "<<endl;
	 cin>>mainChoice;
	 switch(mainChoice)
	 {
	 case 1 :
		do
		{   system("cls");
			cout<<"\n\n\n	 1- Add at the head "<<endl;
			cout<<"	 2- Add randomly "<<endl;
			cout<<"	 3- Add at the tail"<<endl;
			cout<<"	 4- Return to mainChoice"<<endl;
			cin>>subMainChoice;
			switch(subMainChoice)
			{
			case 1 : 
				system("cls");  
				s=createStudent();
				current_ptr=list_head_insert(head_ptr,*s);
				break;
			case 2 : 
				system("cls");
				insert_list_random(head_ptr);
				break;
			case 3 :
				system("cls");  
				s=createStudent();
				current_ptr=list_tail_insert(tail_ptr,*s);
				break;
			case 4 : break;
			default : break;
			}		   
		}while(subMainChoice !=1 && subMainChoice !=2 && subMainChoice !=3 && subMainChoice !=4 ); break;
	 case 2 :
		 system("cls");
		 cout<<"\n\n Enter The Student number : "<<endl;
		 cin>>num;
		 search(head_ptr,num);
		 break; 
	 case 3 :
		do
		{    system("cls");
			cout<<"\n\n\n	 1- Remove at the head "<<endl;
			cout<<"	 2- Remove randomly "<<endl;
			cout<<"	 3- Remove at the tail"<<endl;
			cout<<"	 4- Return to mainChoice"<<endl;
			cin>>subMainChoice;
			switch(subMainChoice)
			{
			case 1 : 
				system("cls");				
				list_head_remove(head_ptr);
				system("pause");				
				break;

			case 2 : 
				system("cls");
				remove_list_random(head_ptr);				
				break;

			case 3 : 
				system("cls");
				list_tail_remove(head_ptr);				
				break;
			case 4 : break;

			default : break;
			}		   
		}while(subMainChoice !=1 && subMainChoice !=2 && subMainChoice !=3 && subMainChoice !=4 ); break;

      case 4 :
			  system("cls");
			  list_contents(head_ptr);
			  system("pause");
			  break;

	  case 5 :
			  system("cls");
			  list_copy(head_ptr,new_head_ptr,new_tail_ptr);
			  cout<<endl<<"The NEW list contents ...BACK UP : "<<endl;	
			  list_contents(new_head_ptr);
			  system("pause");
			  break;
     case 6 :
			  system("cls");
		      cout<<endl<<"The NEW list contents ...BACK UP : "<<endl;
			  list_contents(new_head_ptr);
			   system("pause");
			  break;

    case 7 :
			  system("cls");
			  list_clear(head_ptr);
			 
   default : break;
  }
 }while(mainChoice!=8);
system("pause");
return 0;
}       ///end main()

//create a Student
Student * createStudent()
{ 
	 Student *s= new Student;
	 int num;
	 string name;
	 cout<<"	Enter The Student number : "<<endl;
	 cin>> num;
	 cout<<"	Enter The Student name : "<<endl;
	 cin>> name;
	 s->_num =  num;
	 s->_name  = name;
	 return  s; 
}

//Add at the head
//0)set data to new node
//1)new node next->head
//2)head->new node address
//3)return new node
Node * list_head_insert( Node* & head_ptr, const Node::Element  & entry)
{
	     Node * insert_ptr;
		 insert_ptr = new Node;                                 	
		 insert_ptr -> data  = entry;       
		 insert_ptr -> link  = head_ptr;
		 head_ptr = insert_ptr ; 
		 return insert_ptr;
}

//add randomly
void insert_list_random(Node* & head_ptr)
{ 
  Node * temp = new Node(); 
  temp=head_ptr;

  int num;
  cout<<"\n\n Enter the Student number "<<endl;
  cin>>num;
  bool found=false;
  if(head_ptr == NULL)
  {
   cout<<"\n\n Error : List is empty "<<endl;
  }
  else
  {
     while(temp!=NULL && found==false)
	 {
	    if (temp->data._num == num)
		  {
		   found=true;
		  }
		  else
		  {
			  temp=temp->link;
		  }
	 }
	 if(temp==false)
		 {
		  cout<<"\n\n Error : Student Number does not exist \n\n"<<endl;
		 }
	 else
	 {
	     Student *s;
		 s = new Student;
		 Node * aNode;
		 aNode = new Node;
		 int num;
		 string name;

		 cout<<"	Enter The Student number : "<<endl;
		 cin>>num;
		 cout<<"	Enter The Student name : "<<endl;
		 cin>>name;
 
		 aNode->data._num =  num;
		 aNode->data._name  = name;

		 aNode->link=temp->link;
		 temp->link=aNode;
		 cout<<"\n\n  New list is successfully added "<<endl; 	 
	 }
  
  }
  system("pause");
}

//Add at the tail
Node * list_tail_insert( Node * tail_ptr, const Node::Element & entry)
{
   Node * temp;
   temp=head_ptr;
   //empty list
   if(head_ptr==NULL && tail_ptr==NULL)
   {
	     Node  * insert_ptr;
         insert_ptr = new Node ;
         insert_ptr-> data  = entry;
         insert_ptr -> link  = NULL;
         tail_ptr=insert_ptr;
         head_ptr=insert_ptr;
      return insert_ptr;
   }
   else
     {
	  //temp point to before the last node
	  //0)set data to new node
	  //1)set new node link to null
	  //2)before the last node point to new node
	  //3)tail_prt=new node
      while(temp->link != NULL)
       {
	   temp=temp->link;
       }
	     Node  * insert_ptr;
         insert_ptr = new Node ;
         insert_ptr-> data  = entry;
         insert_ptr -> link  = NULL;
         temp-> link = insert_ptr;
         tail_ptr=insert_ptr;   
     return insert_ptr;
   }
}

//search
void search( Node* & head_ptr, int num)
{
 Node *temp;
 temp= head_ptr;
 bool found=false;
 while(found==false && temp != NULL)
 {
	 if(temp->data._num == num)
	   {
		 found=true;
	   }
	  else 
	   {
		 temp =  temp->link;
	    }
 }
	 if(found == false)
	 {
	  cout<<"  This Student number does not exist "<<endl;
	 }
	 else
	 {
	  cout<<" Student Number : "<<temp->data._num<<"  Student Name : "<<temp->data._name<<endl; 
	 }
 system("pause");
}

//remove at the head
void list_head_remove( Node * & head_ptr)
{
	if (head_ptr==NULL)
	{
		 cout<<"Can not remove an empty list"<<endl;
	}
	else
	{
		head_ptr=head_ptr->link;	
		cout<<"\n\n  The node is successfully removed "<<endl; 	
		system("pause");
	}

}

//remove randomly
void remove_list_random(Node* & head_ptr)
{
	Node * temp = new Node(); 
	Node * previous_ptr=new Node(); 
   temp=head_ptr;

  int num;
  cout<<"\n\n Enter the Student number "<<endl;
  cin>>num;
  bool found=false;
  if(head_ptr == NULL)
  {
   cout<<"\n\n Error : List is empty "<<endl;
  }
  else
  {
     while(temp!=NULL && found==false)
	 {
	    if (temp->data._num == num)
		  {
		   found=true;
		  }
		  else
		  {
			  previous_ptr=temp;
			  temp=temp->link; 
		  }
	 }
	 if(found==false)
		 {
		  cout<<"\n\n Error : Student Number does not exist \n\n"<<endl;
		 }
	 else
	 {
	    //found
		 previous_ptr->link=temp->link;
		 delete temp;
		 cout<<"\n\n  The node is successfully removed "<<endl; 	
	 }
  }
  system("pause");

}

//remove at the tail
void list_tail_remove( Node * & head_ptr)
{
	
	if (head_ptr==NULL)
	{
		 cout<<"Can not remove an empty list"<<endl;
	}
	else
	{
		Node *temp;
	    temp= head_ptr;
	    while(temp->link != NULL)
        {   
		  tail_ptr= temp;
		  temp=temp->link; 
        }
	    tail_ptr->link=NULL;	
		cout<<"\n\n  The node is successfully removed "<<endl; 	
		system("pause");
	}

}

//display
void list_contents(Node   * & head_ptr)
{
	
	Node  * cursor;
	cout<<"\n 		*****the link lists contains***** \n\n\n";
	if(head_ptr==NULL)
	{
		cout<<"\n\n\n   List is empty  \n\n\n"<<endl;
	}
	else
	{
	for(cursor=head_ptr; cursor!=NULL; cursor=cursor->link )
	{
		cout<<"Student number : "<<cursor->data._num<<" Student name : "<<cursor->data._name<<endl<<endl;
	}
	cout<<"\n\n\n\n  ";
	}
}

//copy
void list_copy(Node* source_ptr, Node *& new_head_ptr, Node *& new_tail_ptr)
{

	//handle the case of the empty list
	if (source_ptr == NULL)
	{
		cout<<"The source list is empty"; //return;
		system("pause");

	}
	else
	{
		//Make the head node for the newly created list, and put data in it.
		list_head_insert(new_head_ptr, source_ptr -> data);
		new_tail_ptr = new_head_ptr;

		// Copy  the rest of the nodes a one at a time, adding at the tail of the new list
		for (source_ptr = source_ptr->link; source_ptr != NULL; source_ptr = source_ptr->link)
		{
		  list_insert(new_tail_ptr, source_ptr->data);
		  new_tail_ptr = new_tail_ptr->link;
		}
	
	}	

	
}

Node * list_insert( Node * previous_ptr, const Node::Element & entry)
{
     Node  * insert_ptr;
     insert_ptr          =   new Node ;
     insert_ptr-> data   =   entry;
     insert_ptr -> link  =   previous_ptr->link;
     previous_ptr-> link =   insert_ptr;
  return insert_ptr;
}

//delete
void list_clear( Node *& head_ptr)  
{ 
	while(head_ptr != NULL)
		list_head_remove( head_ptr) ;
	system("cls");
	cout<<"\n\n List is deleted  "<<endl;
	system("pause");
}

//size
size_t list_length(Node  * head_ptr)
{
Node  *  cursor;
size_t total_node=0;
    for(cursor= head_ptr; cursor != NULL; cursor = cursor-> link)
	  total_node++;
return total_node;
}