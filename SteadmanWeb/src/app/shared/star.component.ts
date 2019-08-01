import { Component, OnChanges, Input, Output,EventEmitter } from "@angular/core";


@Component({
    selector: 'pm-star',
    templateUrl: './star.component.html',
    styleUrls: ['./star.component.css']
})
export class StarComponent implements OnChanges {
    
    @Input() rating: number = 4;
    starWidth: number;
    @Output() ratingClicked: EventEmitter<string> = new EventEmitter<string>();

    onClick(): void {
        console.log('This rating is '+ this.rating);
        this.ratingClicked.emit('The rating ' + this.rating + 'was selected.');
    }

    ngOnChanges(): void {
        this.starWidth = this.rating * 75 / 5;
    }

}