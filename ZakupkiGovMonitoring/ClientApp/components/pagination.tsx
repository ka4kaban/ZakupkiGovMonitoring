import * as React from 'react';
//import { NavLink, Link } from 'react-router-dom';

export class Pagination extends React.Component<{}, {}> {
    handleKeyPress() {
    }
    public render() {
        return <div >
            <nav aria-label="Page navigation example">
                <ul className="pagination">
                    <li className="page-item"><a className="page-link" href="#">Previous</a></li>
                    <li className="page-item"><a className="page-link" href="#">1</a></li>
                    <li className="page-item"><a className="page-link" href="#">2</a></li>
                    <li className="page-item"><a className="page-link" href="#">3</a></li>
                    <li className="page-item"><a className="page-link" href="#">Next</a></li>
                </ul>
            </nav>
        </div>;
    }
}
