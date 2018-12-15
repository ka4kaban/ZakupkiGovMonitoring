import { GET_PURCHASE_SUCCESS, GET_PURCHASE_ERROR} from './contactsListConstants.jsx'

//const initialState = {
//    //data: { currentPage: 0, totalPages: 0, pageSize: 0, records: [] },
//    data: { contracts: [] },
//    //post: { tags: [], comments: [] },
//    //author: '',
//    //comment: '',
//    error: ''
//}

const initialState = {
    data: { order: 'asc', orderBy: 'id', contracts: [], page: 0, rowsPerPage: 5},
    error: ''
}


export default function contracts(state = initialState, action) {
    switch (action.type) {
        case GET_PURCHASE_SUCCESS:
            return { ...state, data: action.payload, error: '' }

        case GET_PURCHASE_ERROR:
            return { ...state, error: action.payload }

   //     case ADD_COMMENT_SUCCESS:
   //         return { ...state, author: '', comment: '', error: '' }

   //     case ADD_COMMENT_ERROR:
   //         return { ...state, error: action.payload }

   //     case CHANGE_COMMENT_AUTHOR:
   //         return { ...state, author: action.payload }

   //     case CHANGE_COMMENT_TEXT:
			//return { ...state, comment: action.payload }

        default:
            return state;
    }
}