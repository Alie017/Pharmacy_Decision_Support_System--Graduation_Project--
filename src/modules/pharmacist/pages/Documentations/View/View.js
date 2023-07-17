import React, { useEffect, useState } from 'react'
import { api } from '../../../../../services/api'
import Layout from '../../../layouts/Layout'
import { useParams, Link } from 'react-router-dom'

export default function View() {
	const { id } = useParams()

	const [document, setDocument] = useState({})

	useEffect(() => {
		api.get(`/services/app/Document/GetListDocument`).then(res => {
			res.data.result.forEach(doc => {
				if (doc.id == id) {
					setDocument(doc)
				}
			})
		})
	}, [])

	return (
		<Layout>
			<h3 className='section-title'>{document && document.name}</h3>
			<p>{document && document.description}</p>
			<Link to='/pharmacist/documentations'>return back to documents</Link>
		</Layout>
	)
}
