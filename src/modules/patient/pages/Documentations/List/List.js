import React, { useState, useEffect } from 'react'
import { api } from '../../../../../services/api'
import Layout from '../../../layouts/Layout'
import Table from '../../../../../components/Table/Table'

export default function Documentations() {
	const [documents, setDocuments] = useState([])

	useEffect(() => {
		api.get(`/services/app/Document/GetListDocumentByUserId?userId=${localStorage.getItem('userId')}`)
			.then(res => {
				let documentList = []
				res.data.result.forEach(doc =>
					documentList.push({
						id: doc.id,
						name: doc.name,
						description: doc.description,
						created: doc.creationTime,
					})
				)
				setDocuments(documentList)
			})
	}, [])

	const tableData = {
		title: 'My Documentations',
		searchBtnUrl: '/patient/documentations',
		operations: { view: '/patient/documentations' },
		headings: ['ID', 'Name', 'Description', 'Created Date'],
		rows: documents,
	}

	return (
		<Layout>
			{documents.length > 0 ? <Table data={tableData} /> : <h3 className='section title'>There is no data</h3>}
		</Layout>
	)
}
